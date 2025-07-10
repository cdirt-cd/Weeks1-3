using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    

    public GameObject spawningPrefab;
    public Vector3 spawnPoint;

     List<GameObject> spawnedObjects = new List<GameObject>();
    //List<int> numbers = new List<int>();

    // Start is called before the first frame update
    void Start()
    {

        //spawnedObjects { }

        GameObject spawnedObject = Instantiate(spawningPrefab);
        spawnedObjects.Add(spawnedObject);
        GameObject spawnedObject2 = Instantiate(spawningPrefab, transform.position, Quaternion.identity);
        spawnedObjects.Add(spawnedObject2);

        //spawnedObjects {spawnedObject, spawnedObject2 }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
