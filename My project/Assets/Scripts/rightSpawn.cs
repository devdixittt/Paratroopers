using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject helicopterPrefab;
    public float minTime = 6f;
    public float maxTime = 12f;

    void Start()
    {
        float spawnInterval = Random.Range(minTime, maxTime);
        InvokeRepeating("SpawnRightHelicopter", 0f, spawnInterval);
    }

    private void Update()
    {

    }

    void SpawnRightHelicopter()
    {
        Quaternion spawnRotation1 = Quaternion.Euler(-90f, -90f, 0);
        Instantiate(helicopterPrefab, transform.position, spawnRotation1);
    }
}
