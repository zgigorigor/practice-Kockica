using UnityEngine;

public class obstacleSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject obstaclePrefab;

    // Start is called before the first frame update
    void Start()
    {
        //SpawnLessObstacles();
        SpawnOnlyOnePassage();
    }

    void SpawnLessObstacles()
    {
        int noObsticale = Random.Range(0, spawnPoints.Length);
        int obstacleAmount = Random.Range(0, spawnPoints.Length - 1);
        int j = 0;

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if ( noObsticale != i && j < obstacleAmount )
            {
                Instantiate(obstaclePrefab, spawnPoints[i].position, Quaternion.identity);
                j++;
            }
        }
    }

    void SpawnOnlyOnePassage()
    {
        int noObsticale = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if ( noObsticale != i)
            {
                Instantiate(obstaclePrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}