using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float spawnTime;

    void Start()
    {
        spawnTime = Time.time;    
    }

    void Update()
    {
        if(Time.time > spawnTime + 10) Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) 
        { 
            Destroy(gameObject);
        } else if (gameObject.CompareTag("Enemy") && collision.CompareTag("Player")) {
            collision.GetComponent<Health>().damage();
            Destroy(gameObject);
        }
    }
}
