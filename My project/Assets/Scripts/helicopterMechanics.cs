using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int speed = 2;
    public GameObject paraTroopers;
    private float dropChance = 0.5f;
    private bool paratrooperDropped = false;
    // Start is called before the first frame update
    void Start()
    {
        if (Random.value < dropChance)
        {
            int numDrops = Random.Range(1, 4); // Drop 1-3 paratroopers
            for (int i = 0; i < numDrops; i++)
            {
                float randomDelay = Random.Range(1f, 3f); // Random delay for each drop
                Invoke("DropParatrooper", randomDelay);
            }
            paratrooperDropped = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (transform.position.x > 10.77f || transform.position.x < -10.77f)
        {
            // Destroy the helicopter when it goes off-screen
            Destroy(gameObject);
        }
    }

    void DropParatrooper()
    {
        Instantiate(paraTroopers, transform.position, Quaternion.identity);
    }
}
