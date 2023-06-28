using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            if(collision.gameObject.GetComponent<TopDownMovement>().getKeys() > 0)
            {
                gameObject.SetActive(false);
                collision.gameObject.GetComponent<TopDownMovement>().loseKey();                
            }
        }
    }
}
