using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSpawner : MonoBehaviour
{
    public GameObject spawningPrefab;
    public float spawnFrequency;

    private float timeSinceLastSpawn = 0f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        

        Debug.Log("Time since last spawn: " + timeSinceLastSpawn);

        if (timeSinceLastSpawn > spawnFrequency)
        {
            Instantiate(spawningPrefab);
            timeSinceLastSpawn = 0f;
        }


    }
}
