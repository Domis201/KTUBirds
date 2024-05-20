using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI timerText;
    float elaspedTime;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("timeValue")) 
        {
            elaspedTime = PlayerPrefs.GetFloat("timeValue");
        }
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            resetTimer();
        }
    }

    // Update is called once per frame
    void Update()
    {
        elaspedTime += Time.deltaTime;
        PlayerPrefs.SetFloat("timeValue", elaspedTime);
        int minutes = Mathf.FloorToInt(elaspedTime / 60);
        int seconds = Mathf.FloorToInt(elaspedTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void resetTimer()
    {
        elaspedTime = 0;
        PlayerPrefs.SetFloat("timeValue", elaspedTime);
    }
}
