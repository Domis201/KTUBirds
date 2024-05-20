using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace TimeBoards.Board
{
    public class TimeboardEntryUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI entryNameText = null;
        [SerializeField] private TextMeshProUGUI entryTimeText = null;

        public void Initialise(TimeboardEntryData timeboardEntryData)
        {
            entryNameText.text = timeboardEntryData.entryName;
            int minutes = Mathf.FloorToInt(timeboardEntryData.entryTime / 60);
            int seconds = Mathf.FloorToInt(timeboardEntryData.entryTime % 60);
            entryTimeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

    }

   
}


