using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
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
        scoreText.text = ( player.position.z.ToString("0") + " m" );
        livesText.text = ( lives.ToString() );
    }

    public void LoseLife( int l = 1 )
    {
        lives -= l;
        if ( lives <= 0 )
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        else
        {
            FindObjectOfType<GameManager>().GoAgain();
        }

    }
}