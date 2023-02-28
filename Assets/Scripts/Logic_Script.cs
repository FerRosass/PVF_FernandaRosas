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


    public void addScore(int pointsToAdd)
    {
        playerPoints = playerPoints + pointsToAdd;
        pointsText.text = playerPoints.ToString();
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

}
