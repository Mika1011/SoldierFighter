using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
   
    void Update()
    {
        transform.Rotate(1, 1, 1);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            transform.SetParent(collision.gameObject.transform);
            transform.position = collision.gameObject.transform.position + new Vector3(0, 1, 0);
            transform.localScale = transform.localScale / 2;
            collision.gameObject.GetComponent<TopDownMovement>().addKey(gameObject);
        }
    }
}
