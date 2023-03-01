using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logic_Script : MonoBehaviour
{
    public int playerPoints;
    public Text pointsText;
    public GameObject GameOverScreen;
    public Object_Spawner spawner;
    public GameObject InstructionsUI;

    public void addScore(int pointsToAdd)
    {
        playerPoints = playerPoints + pointsToAdd;
        pointsText.text = playerPoints.ToString();
    }
    public void startGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Nivel01");
    }
    
    public void restartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        GameOverScreen.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Quit()
    {
        Debug.Log("Saliendo...");
        Application.Quit();
    }
    public void Back()
    {
        InstructionsUI.SetActive(false);
        Time.timeScale = 1f;

    }
    public void InstructionsPanel()
    {
        InstructionsUI.SetActive(true);
        Time.timeScale = 0f;

    }
}
