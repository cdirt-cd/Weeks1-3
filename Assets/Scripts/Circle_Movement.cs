using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle_Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
        transform.position = newPosition;
    }
}
