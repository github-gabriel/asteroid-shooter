using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Text HStext;

    private void Start()
    {
        HStext.text = "Highscore: " + PlayerPrefs.GetInt("highscore");
    }
    private void Update()
    {
        HStext.text = "Highscore: " + PlayerPrefs.GetInt("highscore");
    }
    public void StartButton()
    {
        Time.timeScale = 1f;
        StaticClass.score = 0;
        SceneManager.LoadScene("Game");
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void ResetScore()
    {
        PlayerPrefs.SetInt("highscore", 0);
        HStext.text = "Highscore: 0";
    }
}
