using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text livesText;
    private int lives;

    void Start()
    {
        lives = FindObjectOfType<GameManager>().lives;
    }

    // Update is called once per frame
    void Update()
    {
        //CheckLives();
        scoreText.text = ( player.position.z.ToString("0") + " m" );
        livesText.text = ( lives.ToString() );
    }

    private void CheckLives()
    {
        if ( lives <= 0 )
        {
            Debug.Log( "Game Over! All lives lost..." );
            FindObjectOfType<GameManager>().EndGame();
        }
        else
        {
            Debug.Log( "Remaining lives: " + lives );
            //FindObjectOfType<GameManager>().GoAgain();
        }
    }

    public int GainLife( int l = 1 )
    {
        lives += l;
        return lives;
    }

    public int LoseLife( int l = 1 )
    {
        lives -= l;
        return lives;
    }
}