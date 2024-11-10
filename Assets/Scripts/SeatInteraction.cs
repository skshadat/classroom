using UnityEngine;

public class SeatInteraction : MonoBehaviour
{
    private bool isOccupied = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isOccupied)
        {
            // Move the player to the seat position
            other.transform.position = transform.position;
            other.transform.rotation = transform.rotation;
            isOccupied = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOccupied = false;
        }
    }
}