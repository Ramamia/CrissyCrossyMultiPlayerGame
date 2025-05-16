using UnityEngine;

public class CameraFollowCarRight : MonoBehaviour
{
    [SerializeField] Transform rightPlayer;
    [SerializeField] Vector3 offset = new Vector3(0, 5, -10);
    [SerializeField] float smoothSpeed = 5f;

    void LateUpdate()
    {
        if (rightPlayer == null) return;

        Vector3 desiredPosition = rightPlayer.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        transform.LookAt(rightPlayer);
    }
}
