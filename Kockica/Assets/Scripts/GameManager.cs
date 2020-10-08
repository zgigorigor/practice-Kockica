using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    float slowTime = 10f;
    public GameObject completeLevelUI;
    public static int lives = 3;
    public float speed = 1000;
    public float force = 2500;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive( true );
        Debug.Log( "level completed" );
    }
    public void EndGame()
    {
        if ( gameEnded == false )
        {
            gameEnded = true;
            Debug.Log( "Game Over!" );
            StartCoroutine( SlowMotionRestartLevel() );
        }
    }

    public void Restart()
    {
        StartCoroutine( RestartLevel() );
        lives -= 1;
    }

    IEnumerator RestartLevel()
    {
        yield return new WaitForSeconds( 1f );
        SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
    }

    IEnumerator SlowMotionRestartLevel()
    {
        Time.timeScale = 1f / slowTime;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowTime;

        yield return new WaitForSeconds( 1f / slowTime );

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowTime;

        SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
    }
}