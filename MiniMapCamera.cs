using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapCamera : MonoBehaviour
{
    [SerializeField] Transform player;

    Vector3 offset = new Vector3(0, 0, -10);

    private void Update()
    {
        transform.position = player.position + offset;
    }
}
