using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public static bool gamePause = false;
    public GameObject pauseMenuUI;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gamePause)
            {
                Resume();
            }
            else
            {
                PauseMenu();
            }
        }
    }
    public void Resume()
    {

        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gamePause = false;

    }
    void PauseMenu()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gamePause=true;
        
    }
    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void Quit()
    {
        Debug.Log("Saliendo...");
        Application.Quit(); 
    }

}
