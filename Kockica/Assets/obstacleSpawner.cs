using UnityEngine;

public class obstacleSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject obstaclePrefab;

    // Start is called before the first frame update
    void Start()
    {
        int noObsticale = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if ( noObsticale != i )
            {
                Instantiate(obstaclePrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}
