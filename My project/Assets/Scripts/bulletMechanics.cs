using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMechanics : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
       
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("paraTroopers") || collision.CompareTag("helicopter"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
