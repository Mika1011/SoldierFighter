using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    [SerializeField] GameObject endScreen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            endScreen.SetActive(true);
            FindObjectOfType<Health>().Imortal = true;
            FindObjectOfType<Timer>().stop();
        }
    }
}
