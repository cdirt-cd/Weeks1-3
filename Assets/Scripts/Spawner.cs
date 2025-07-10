using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    

    public GameObject spawningPrefab;
    public Vector3 spawnPoint;

    // Start is called before the first frame update
    void Start()
    {

        Gameobject spawnedObject = Instantiate(spawningPrefab);
        Destroy(spawnedObject);
        Gameobject spawnedObject2 = Instantiate(spawningPrefab, transform.position, Quaternion.identity);
        Destroy(spawnedObject2, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
