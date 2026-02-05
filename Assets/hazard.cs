using UnityEngine;

public class Hazard : MonoBehaviour
{
    [SerializeField] private Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that touched this mesh is the player
        if (other.CompareTag("Player"))
        {
            // Move the player to the respawn point's position
            other.transform.position = respawnPoint.position;
        }
    }
}