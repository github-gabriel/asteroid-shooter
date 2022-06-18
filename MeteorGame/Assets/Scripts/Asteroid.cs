using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Asteroid : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    public ParticleSystem explosion;
    private ParticleSystem ps;
    private Vector2 pos;
    public Text text;
    public GameObject gameOverUI;
    public Text gameOver_score;

    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < screenBounds.x - 10 && gameObject.name == "asteroid(Clone)") // This is the difference. Put -25.
        {
            Destroy(this.gameObject);
            Time.timeScale = 0f;
            gameOverUI.SetActive(true);
            gameOver_score.text = "Score: " + StaticClass.score;
            if(StaticClass.score > PlayerPrefs.GetInt("highscore"))
            {
                PlayerPrefs.SetInt("highscore", StaticClass.score);
            }
            // Game Over Screen
        }
    }
    private void OnMouseDown()
    {
        StaticClass.score += 1;
        text.text = "" + StaticClass.score;

        pos = new Vector2(gameObject.transform.position.x - 1.5f, gameObject.transform.position.y);

        ParticleSystem ps = Instantiate(explosion);
        ps.transform.position = pos;
        ps.Play();

        Destroy(this.gameObject);
    }
}