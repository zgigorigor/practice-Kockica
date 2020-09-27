using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("obstacle hit");
            movement.enabled = false;
            //FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<ScoreManager>().LoseLife();
        }
    }
}