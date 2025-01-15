using UnityEngine;

public class MinuteHandRotation : MonoBehaviour
{
    // setting rotation speed for hour hand
    public float rotationSpeed = 360f;

    void Update()
    {
        float rotationThisFrame = rotationSpeed * Time.deltaTime;

        transform.Rotate(Vector3.back, rotationThisFrame);
    }
}

