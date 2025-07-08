using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle_rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newRotation = transform.eulerAngles + Vector3.forward * 1f;
        newRotation.z += 1f;
        newRotation.x += 1f;
        newRotation.y += 1f;
        transform.eulerAngles = newRotation;
    }
}
