using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle_rotation : MonoBehaviour
{
    public Camera gameCamera;
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 newRotation = transform.eulerAngles + Vector3.forward * 1f;
        //newRotation.z += 1f;
        //newRotation.x += 1f;
        //newRotation.y += 1f;
        Vector3 mousePositionInWorldSpace = gameCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePositionInWorldSpace.z = 0f;

        Vector3 start = transform.position;
        Vector3 target = mousePositionInWorldSpace;

        Vector3 direction = target - start;

        transform.up = direction;

        //transform.eulerAngles = newRotation;
    }
}
