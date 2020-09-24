using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    float slowTime = 10f;
    public void EndGame()
    {
        Debug.Log("Game Over!");
        StartCoroutine( RestartLevel() );
    }

    IEnumerator RestartLevel()
    {
        Time.timeScale = 1f / slowTime;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowTime;

        yield return new WaitForSeconds(1f / slowTime);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowTime;

        SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
    }
}