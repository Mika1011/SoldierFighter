using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;

    [SerializeField] Transform aimPoint;

    [SerializeField] AudioSource shootingSource;

    [SerializeField] float shootingForce;

    Vector3 mousePosition;

    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }

    void shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().AddForce((aimPoint.position - transform.position) * shootingForce, ForceMode2D.Impulse);
        shootingSource.Play();
    }
}
