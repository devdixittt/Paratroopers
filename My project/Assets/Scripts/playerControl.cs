using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    public Transform firePoint;
    private float minAngle = -20f;
    private float maxAngle = 20f;

    void Update()
    {
        // Get the mouse position in world coordinates
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Calculate the direction from the turret to the mouse position
        Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);

        // Calculate the angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Clamp the angle between -45 and 45 degrees
        angle = Mathf.Clamp(angle, minAngle, maxAngle);

        // Apply the rotation to the turret
        transform.rotation = Quaternion.Euler(0, 0, angle);
        if (Input.GetKeyDown(KeyCode.Space)) // Shoot
        {
            Shoot();
            if (transform.position.y > 4f)
            {
                Destroy(bulletPrefab.gameObject);
            }
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
