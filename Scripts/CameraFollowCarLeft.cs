using UnityEngine;

public class CameraFollowCarLeft : MonoBehaviour
{
    [SerializeField] Transform leftPlayer;
    [SerializeField] Vector3 offset = new Vector3(0, 5, -10);
    [SerializeField] float smoothSpeed = 5f;

    void LateUpdate()
    {
        if (leftPlayer == null) return;

        Vector3 desiredPosition = leftPlayer.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.LookAt(leftPlayer); // Optional: make camera look at the car
    }
}
