using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser_script : MonoBehaviour
{
    public Vector3 newPosition;
    public Camera gameCamera;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePositionInWorldSpace = gameCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePositionInWorldSpace.z = 0f;



        Vector3 start = transform.position;
        Vector3 target = mousePositionInWorldSpace;
        Vector3 directionToMove = target - start;

        transform.position = transform.position + directionToMove;

    }
}
