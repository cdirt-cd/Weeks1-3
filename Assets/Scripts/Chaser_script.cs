using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    public Vector3 newPosition;
    public Camera gameCamera;
    public SpriteRenderer chserRenderer;


    public float speed;
    Vector3 lastClickedPosition = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Yo wassup");
    }

    // Update is called once per frame
    void Update()
    {
        
        

        Vector3 mousePositionInWorldSpace = gameCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePositionInWorldSpace.z = 0f;

        if(Input.GetMouseButtonDown(0))
        {
            lastClickedPosition = mousePositionInWorldSpace;
        }

        Vector3 start = transform.position;
        Vector3 target = lastClickedPosition;
        Vector3 directionToMove = target - start;

        transform.position = transform.position + directionToMove * speed;

        Vector3 chaserPositionInScreenSpace = gameCamera.WorldToScreenPoint(transform.position);
        //Debug.Log("Chaser position in ScreenSpace = " + chaserPositionInScreenSpace.ToString());

        float xMin = 0f;
        //float yMin = 0f;
        
        float xMax = Screen.width;
        //float yMax = Screen.height;

        //If chaser x is less than the xmin
        //If chaser y is less than the ymin
        //if chaser x is greater than the xmax
        //if chaser y is greater than the ymax
        //THEN:
        //change the colour of the chaser to red

        bool xMaxExceeded = chaserPositionInScreenSpace.x >= xMax;
        bool notLessThanXMin = chaserPositionInScreenSpace.x <= xMin;

        Debug.Log("xMaxExceeded = " + xMaxExceeded.ToString());
        Debug.Log("xMinExceeded = " + notLessThanXMin.ToString());

        if (xMaxExceeded || notLessThanXMin) 
        {
            chserRenderer.color = Color.red;
        }
        else
        {
            chserRenderer.color = Color.white;
        }




        

    }
}
