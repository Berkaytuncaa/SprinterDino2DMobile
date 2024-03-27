using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreText;

    public GameObject pauseButton;
    public GameObject pauseScreen;

    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseScreen.SetActive(true);
        pauseButton.SetActive(false);
    }

    public void ContuniueGame()
    {
        Time.timeScale = 1;
        pauseButton.SetActive(true);
        pauseScreen.SetActive(false);
    }

    public void goMenu()
    {
        SceneManager.LoadScene(0);
    }
}
