using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    Vector3 mousePosition;
    Vector3 direction;

    [SerializeField] Camera mainCamera;

    void Update()
    {
        mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        direction = mousePosition - transform.position;

        transform.rotation = Quaternion.LookRotation(Vector3.forward, direction);
    }
}
