using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacer : MonoBehaviour
{
    public float speed;
   
    private float direction = 1f;

     

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * direction;
        
        Vector3 pacerPositionInScreenSpace = Camera.main.WorldToScreenPoint(transform.position);

        if (pacerPositionInScreenSpace.x > Screen.width)
        {
            direction *= -1f; 
        }

        if (pacerPositionInScreenSpace.x < 0f)
        {
            direction *= -1f;
        }
    }
}
