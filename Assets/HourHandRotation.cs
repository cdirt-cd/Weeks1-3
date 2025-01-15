using UnityEngine;

public class HourHandRotation : MonoBehaviour
{
    // setting rotation speed for hour hand
    public float rotationSpeed = 30f;

    void Update()
    {
        float rotationThisFrame = rotationSpeed * Time.deltaTime;

        transform.Rotate(Vector3.back, rotationThisFrame);
    }
}
    
 
