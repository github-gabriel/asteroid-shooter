using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Restart()
    {
        SceneManager.UnloadScene("Game");
        StaticClass.score = 0;
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
    }
}
