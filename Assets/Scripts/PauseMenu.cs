using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public AudioManager audioManager;
    public GameObject pauseMenuUI;
    public GameObject finalLevelUI;
    //public GameObject deathResUI;
    //public GameObject finalLevelUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        audioManager.PlayClicked();
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void LoadMenu()
    {
        audioManager.PlayClicked();
        string mainMenu = "MainMenu";
        Time.timeScale = 1f;
        SceneManager.LoadScene(mainMenu);
        Debug.Log("Go to MainMenu");
        gameIsPaused = false;
    }

    public void Quit()
    {
        audioManager.PlayClicked();
        Time.timeScale = 1f;
        gameIsPaused = false;
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void LevelFinished()
    {
        //audioManager.Play
        finalLevelUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level");
        gameIsPaused = false;
    }
}
