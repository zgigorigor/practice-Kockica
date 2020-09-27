using System.Collections.Generic;
using UnityEngine;

public class obstacleSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject obstaclePrefab;
    // TODO:
    // napraviti listu brojeva od 1-6 sa random pozicijama za prolaze tj. prepreke
    //public List[] obstacleAmount;

    // Start is called before the first frame update
    void Start()
    {
        //SpawnLessObstacles();
        //SpawnOnlyOnePassage();
        SpawnTwoPassages();
    }

    void SpawnLessObstacles()
    {
        int noObsticale = Random.Range(0, spawnPoints.Length);
        int obstacleAmount = Random.Range(0, spawnPoints.Length - 1);
        int j = 0;

        for ( int i = 0; i < spawnPoints.Length; i++ )
        {
            if ( noObsticale != i && j < obstacleAmount )
            {
                Instantiate( obstaclePrefab, spawnPoints[i].position, Quaternion.identity );
                j++;
            }
        }
    }

    void SpawnOnlyOnePassage()
    {
        int noObsticale = Random.Range(0, spawnPoints.Length);

        for ( int i = 0; i < spawnPoints.Length; i++ )
        {
            if ( noObsticale != i )
            {
                Instantiate( obstaclePrefab, spawnPoints[i].position, Quaternion.identity );
            }
        }
    }

    void SpawnTwoPassages()
    {
        int firstPassage = Random.Range( 0, spawnPoints.Length );
        int secondPassage = Random.Range( firstPassage, spawnPoints.Length );
        
        for ( int i = 0; i < spawnPoints.Length; i++ )
        {
            Debug.Log ( "first pass: " + firstPassage );
            Debug.Log ( "second pass: " + secondPassage );
            Debug.Log ( "spawn point: " + spawnPoints[i].position );
            if ( firstPassage != i )
            {
                if ( secondPassage != i )
                {
                    Instantiate( obstaclePrefab, spawnPoints[i].position, Quaternion.identity );
                }
            }
        }
    }
}