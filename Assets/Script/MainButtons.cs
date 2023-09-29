using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButtons : MonoBehaviour
{
    public GameObject PauseWindow;
    public void startGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("game");
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("game");
    }
    public void Home()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("home");
    }
    public void Play()
    {

        Time.timeScale = 1f;
        PauseWindow.SetActive(false);
    }
    public void pause()
    {
        Time.timeScale=0f;
        PauseWindow.SetActive(true);

    }
    public void appQuit()
    {
        Application.Quit();
    }
}
