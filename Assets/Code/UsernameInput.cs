using System.Collections;
using System.Collections.Generic;
using TimeBoards.Board;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UsernameInput : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI username;
    [SerializeField] TimeBoard timeBoard;
    // Start is called before the first frame update
    void Start()
    {
        username.text = PlayerPrefs.GetString("user_name");
        
    }


    [ContextMenu("Add Entry")]
    public void AddEntries()
    {
        username.text = username.text;
        PlayerPrefs.SetString("user_name", username.text);

        TimeboardEntryData testEntryData = new TimeboardEntryData() { entryName = PlayerPrefs.GetString("user_name"), entryTime = PlayerPrefs.GetFloat("timeValue") };
        Debug.Log(PlayerPrefs.GetString("user_name").ToString());
        Debug.Log(PlayerPrefs.GetFloat("timeValue").ToString());
        timeBoard.AddEntry(testEntryData);
    }
}
