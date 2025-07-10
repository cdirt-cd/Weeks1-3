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
        Instantiate(spawningPrefab);
        Instantiate(spawningPrefab, transform.position, Quaternion.identity);
        Destroy (gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
