using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    float slowTime = 10f;
    public GameObject completeLevelUI;
    public int lives = 3;
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
            StartCoroutine( RestartLevel() );
        }
    }

    public void GoAgain()
    {
        StartCoroutine( RestartLevel() );
    }

    IEnumerator RestartLevel()
    {
        Time.timeScale = 1f / slowTime;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowTime;

        yield return new WaitForSeconds( 1f / slowTime );

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowTime;

        SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
    }
}