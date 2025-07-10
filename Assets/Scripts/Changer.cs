using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changer : MonoBehaviour
{
    private float time = 0f;
    public SpriteRenderer changerRenderer;


    //private timeSinceLastSpawn = 0f; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;
        


        if (time > 3f)
        {
            changerRenderer.color = Color.green;
        }
        else
        {
            changerRenderer.color = Color.white;
        }

        if (time > 4f)
        {
            transform.localScale = new Vector3(2f, 2f, 2f);
        }

        if (time > 5f)
        {
            transform.eulerAngles = new Vector3(0f, 0f, 45f);
        }

        if (time > 6f)
        {
            Destroy(gameObject);
        }
    }
}
