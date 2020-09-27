using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Obstacle hit!");
            movement.enabled = false;
            // TODO:
            // pauzirat igru, da se ne mice player
            FindObjectOfType<ScoreManager>().LoseLife();
            RestartLevel();
        }
    }

    private void RestartLevel()
    {
        FindObjectOfType<GameManager>().Restart();
    }
}