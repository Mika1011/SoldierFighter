using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] Animator animator;

    private Rigidbody2D rb;
    private Vector2 movement;

    float moveX;
    float moveY;

    [SerializeField] int keys = 0;

    [SerializeField] List<GameObject> keyList;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        myInput();

        animator.SetFloat("Speed", rb.velocity.magnitude);

        movement = new Vector2(moveX, moveY);

        movement.Normalize();
    }

    private void FixedUpdate()
    {
        if (GetComponent<Health>().IsDead == false)
        {
            rb.velocity = movement * moveSpeed;
        }
    }
    void myInput()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
    }

    public void addKey(GameObject key)
    {
        keys++;
        keyList.Add(key);
    }

    public int getKeys()
    {
        return keys;
    }

    public void loseKey()
    {
        keys--;
        if (keyList.Count > 0)
        {
            Destroy(keyList[0]);
            keyList.RemoveAt(0);
        }
    }
}
