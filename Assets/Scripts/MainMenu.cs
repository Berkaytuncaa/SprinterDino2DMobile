using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button playButton;
    public Button quitButton;
    public Button optionsButton;
    public GameObject optionsPanel;

    public void StartNewGame()
    {
        Color buttonColor = playButton.GetComponent<Image>().color;
        buttonColor.a /= 2f;
        playButton.GetComponent<Image>().color = buttonColor;

        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Color buttonColor = quitButton.GetComponent<Image>().color;
        buttonColor.a /= 2f;
        quitButton.GetComponent<Image>().color = buttonColor;

        Application.Quit();
    }

    public void Options()
    {
        Color buttonColor = optionsButton.GetComponent<Image>().color;
        buttonColor.a /= 2f;
        optionsButton.GetComponent<Image>().color = buttonColor;

        optionsPanel.SetActive(true);
    }

    public void ClosePanel()
    {
        Color buttonColor = optionsButton.GetComponent<Image>().color;
        buttonColor.a *= 2f;
        optionsButton.GetComponent<Image>().color = buttonColor;
        optionsPanel.SetActive(false);
    }
}
