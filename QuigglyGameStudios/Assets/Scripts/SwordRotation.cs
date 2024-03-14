using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordRotation : MonoBehaviour
{
    private float leftright;
    private float updown;
    private Vector3 swordrotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftright = Input.GetAxis("Horizontal");
        updown = Input.GetAxis("Vertical");
        swordrotation = transform.rotation.eulerAngles;

        
        if (updown > 0.1) // Up
        {
            swordrotation.z = 0.0f;
            transform.rotation = Quaternion.Euler(swordrotation);
        }
        else if (updown < -0.1) // Down
        {
            swordrotation.z = 180.0f;
            transform.rotation = Quaternion.Euler(swordrotation);
        }
        else if (leftright > 0.1) // Right
        {
            swordrotation.z = -90.0f;
            transform.rotation = Quaternion.Euler(swordrotation);
        }
        else if (leftright < -0.01) // Left\
        {
            swordrotation.z = 90.0f;
            transform.rotation = Quaternion.Euler(swordrotation);
        }


        
    }
}
