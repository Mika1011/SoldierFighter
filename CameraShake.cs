using System.Collections;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float shakeDuration = 0.1f;
    public float shakeIntensity = 0.5f;

    private Transform cameraTransform;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    public void shake()
    {
        StartCoroutine(shakeCoroutine());
    }

    private IEnumerator shakeCoroutine()
    {
        float elapsedTime = 0f;

        while (elapsedTime < shakeDuration)
        {
            Vector3 randomOffset = Random.insideUnitSphere * shakeIntensity;
            cameraTransform.localPosition += randomOffset;

            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
}