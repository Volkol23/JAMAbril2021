using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pauseMenuUI;
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
        string mainMenu = "MainMenu";
        Time.timeScale = 1f;
        //SceneManager.LoadScene(mainMenu);
        Debug.Log("Go to MainMenu");
        gameIsPaused = false;
    }

    public void Quit()
    {
        //SceneManager.LoadScene("Level1_Desert");
        Time.timeScale = 1f;
        gameIsPaused = false;
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void LevelFinished()
    {
        //finalLevelUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Prueba");
        gameIsPaused = false;
    }
}
