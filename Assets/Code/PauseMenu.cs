using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();

    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        audioManager.PlaySFX(audioManager.buttonClick);
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        audioManager.PlaySFX(audioManager.buttonClick);
    }
    public void Quit()
    {
        SceneManager.LoadSceneAsync(0);
        Time.timeScale = 1;
    }
	public void Reset()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}


}
