using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // reference to fire point
    public Transform firePoint;
    public GameObject bulletPrefab;           //Reference to the GameObject Bullet

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //Shooting Logic
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);     //Spawn a bullet by Instatiating

    }
}
