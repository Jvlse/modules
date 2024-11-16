using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject livesHolder;
    public GameObject gameOverPanel;
    int score = 0;
    int lives = 3;
    bool gameOver = false;
    public TMP_Text textComponent;

    private void Awake()
    {
        instance = this;
    }

    public void IncrementScore()
    {
        if(!gameOver)
        {
            score++;
            string scoreString = score.ToString();
            textComponent.text = scoreString;  
        }
    }

    public void DecreaseLives()
    {
        if (lives > 0)
        {
            lives--;
            livesHolder.transform.GetChild(lives).gameObject.SetActive(false);
        }

        if (lives <= 0)
        {
            gameOver = true;
            GameOver();
        }
    }

    public void GameOver()
    {
        print("Game Over");

        CandySpawner.instance.StopSpawningCandies();
        GameObject.FindGameObjectsWithTag("Candy");
        GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;
        gameOverPanel.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
