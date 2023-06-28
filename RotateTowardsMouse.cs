using UnityEngine;

public class RotateTowardsMouse : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float distanceFromPlayer = 2f;

    private void Update()
    {
        positionAndRotateAroundPlayer();
    }

    private void positionAndRotateAroundPlayer()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;

        Vector3 direction = mousePosition - player.position;
        direction.Normalize();

        Vector3 targetPosition = player.position + direction * distanceFromPlayer;
        transform.position = targetPosition;
    }
}
