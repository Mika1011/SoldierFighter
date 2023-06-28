using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.5f;
    public Vector3 offset;

    [SerializeField] Camera cameraPrefab;

    private void Start()
    {
        if(cameraPrefab.GetComponent<PostProcessVolume>().enabled == false)
        {
            GetComponent<PostProcessVolume>().enabled = false;
        } else if(cameraPrefab.GetComponent<PostProcessVolume>().enabled == true)
        {
            GetComponent<PostProcessVolume>().enabled = true;
        }
    }

    private void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
        }
    }
}

