using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftSpawn : MonoBehaviour
{
    public GameObject helicopterPrefab;
    public float minTime = 5f;
    public float maxTime = 10f;


    void Start()
    {
        float spawnInterval = Random.Range(minTime, maxTime);
        InvokeRepeating("SpawnLeftHelicopter", 0f, spawnInterval);
    }

    private void Update()
    {
     
    }

    void SpawnLeftHelicopter()
    {

        Quaternion spawnRotation = Quaternion.Euler(-90f, 90f, 0);
        Instantiate(helicopterPrefab, transform.position, spawnRotation);
    }
}
