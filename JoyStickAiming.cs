using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStickAiming : MonoBehaviour
{
    public Transform gunBarrel;
    private Vector2 aimDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("HorizontalRightStick");
        float vertical = Input.GetAxis("VerticalRightStick");
        aimDirection = new Vector2(horizontal, vertical).normalized;

        // Rotate gun barrel to aim towards the aim direction
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        gunBarrel.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    
}
