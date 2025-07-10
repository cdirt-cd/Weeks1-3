using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    

    public GameObject spawningPrefab;
    public Vector3 spawnPoint;
    public int framerate;

    List<GameObject> spawnedObjects = new List<GameObject>();
    //List<int> numbers = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = framerate;
        //spawnedObjects { }

        //GameObject spawnedObject = Instantiate(spawningPrefab);
        //spawnedObjects.Add(spawnedObject);
        //GameObject spawnedObject2 = Instantiate(spawningPrefab, transform.position, Quaternion.identity);
        //spawnedObjects.Add(spawnedObject2);

        //spawnedObject.Insert(2, spawnedObject); insert new object

        //spawnedObjects[0] = spawnedObject2; replaces object at index 0 with spawnedObject2

        //to clear the whole list spawnedObjects.Clear(); doesn't destroy the objects, just clears the list


        //Destroy(spawnedObjects[0])
        //spawnedObjects {spawnedObject, spawnedObject2 }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            for (int i = 0; i < spawnedObjects.Count; i++)
            {
                Destroy(spawnedObjects[i]);
            }
            spawnedObjects.Clear();


            //foreach(GameObject spawnedObject in spawnedObjects)
            // {
            //     Destroy(spawnedObjects[i]);
            // }


        }


        //spawnedObject.Add(Instantiate(spawningPrefab) 

    }
}
}
