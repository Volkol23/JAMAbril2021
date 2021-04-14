using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject menu;

    public AudioManager audioManager;
    private void Awake()
    {
        //Debug.Log();
        //audioManager = GetComponent<AudioManager>();
    }
    private void Start()
    {
        
    }
    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
        Debug.Log("Choose Level!");
    }

    public void GoToCilckedButton(GameObject label)
    {
        menu.SetActive(false);
        audioManager.PlayClicked();
        label.SetActive(true);
    }


    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void Back(GameObject label)
    {
        label.SetActive(false);
        audioManager.PlayClicked();
        menu.SetActive(true);
    }
}
