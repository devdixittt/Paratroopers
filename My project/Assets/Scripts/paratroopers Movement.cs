using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paratroopersMovement : MonoBehaviour
{
    public float fallSpeed = 2f;
    public float climbSpeed = 1f;
    private bool isClimbing = false;

    private void Start()
    {
        
    }
    void Update()
    {
        if (!isClimbing)
        {
            transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);
            if (gameObject.CompareTag("Ground")) // Ground level
            {
                isClimbing = true;
            }
        }
        else
        {
            transform.Translate(Vector2.up * climbSpeed * Time.deltaTime);
        }
    }
}
