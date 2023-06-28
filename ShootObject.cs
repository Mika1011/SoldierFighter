using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootObject : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform shootingpoint;

    float nextTimeToShoot = 0;
    [SerializeField] float fireRate = 5;

    [SerializeField] float shootingForce;

    void Start()
    {
        
    }

    void Update()
    {
        if(Time.time > nextTimeToShoot)
        {
            shoot();
            nextTimeToShoot = Time.time + 1F / fireRate;
        }
    }
    void shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, shootingpoint.position, transform.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce((shootingpoint.position - transform.position) * 100 * shootingForce, ForceMode2D.Force);
    }
}
