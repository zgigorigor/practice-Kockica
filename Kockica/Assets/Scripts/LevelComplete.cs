using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{

    // dodati scoreText i livesText i gameMessageText

    // gameMessageText nekoliko poruka ovisno o rezultatu

    public void LoadNextLevel()
    {
        SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );

    }
}
