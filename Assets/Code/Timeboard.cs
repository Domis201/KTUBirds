using System.IO;
using UnityEngine;

namespace TimeBoards.Board
{
    public class TimeBoard : MonoBehaviour
    {
        [SerializeField] private int maxTimeboardEntries = 4;
        [SerializeField] private Transform timeHolderTransform = null;
        [SerializeField] private GameObject timeboardEntryObject = null;
        [Header("Test")]
        [SerializeField] private string testEntryName = "New Name";
        [SerializeField] private int testEntryTime = 0;
        


        private string SavePath => $"{Application.persistentDataPath}/timescores.json";

        private void Start()
        {
            TimeboardSavedData savedTime = GetSavedTime();

            UpdateUI(savedTime);

            SavedTimes(savedTime);
        }

        [ContextMenu("Add Test Entry")]

        public void AddTestEntry()
        {
            AddEntry(new TimeboardEntryData()
            {
                entryName = testEntryName,
                entryTime = testEntryTime
            });
        }

        public void AddEntry(TimeboardEntryData timeboardEntryData)
        {
            TimeboardSavedData savedTimes = GetSavedTime();

            bool timeAdded = false;

            for(int i = 0; i < savedTimes.times.Count; i++)
            {
                if(testEntryTime  > savedTimes.times[i].entryTime)
                {
                    savedTimes.times.Insert(i, timeboardEntryData);
                    timeAdded = true;
                    break;
                }
            }

            if(!timeAdded && savedTimes.times.Count < maxTimeboardEntries)
            {
                savedTimes.times.Add(timeboardEntryData);
            }
            if(savedTimes.times.Count > maxTimeboardEntries)
            {
                savedTimes.times.RemoveRange(maxTimeboardEntries, savedTimes.times.Count - maxTimeboardEntries);
            }

            UpdateUI(savedTimes);
            SavedTimes(savedTimes);
        }

        private void UpdateUI(TimeboardSavedData savedTime)
        {
            foreach(Transform child in timeHolderTransform)
            {
                Destroy(child.gameObject);
            }
            foreach(TimeboardEntryData time in savedTime.times)
            {
                Instantiate(timeboardEntryObject, timeHolderTransform).
                    GetComponent<TimeboardEntryUI>().Initialise(time);
            }
        }

        private TimeboardSavedData GetSavedTime()
        {
            if(!File.Exists(SavePath))
            {
                File.Create(SavePath).Dispose();
                return new TimeboardSavedData();
            }

            using(StreamReader stream = new StreamReader(SavePath))
            {
                string json = stream.ReadToEnd();
                return JsonUtility.FromJson<TimeboardSavedData>(json);
            }

        }

        private void SavedTimes(TimeboardSavedData timeboardSavedData)
        {
            using(StreamWriter stream = new StreamWriter(SavePath))
            {
                string json = JsonUtility.ToJson(timeboardSavedData, true);
                stream.Write(json);
            }
        }
    }
}


