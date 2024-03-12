using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordRotation : MonoBehaviour
{
    private float leftright;
    private float updown;
    private float swordrotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftright = Input.GetAxis("Horizontal");
        updown = Input.GetAxis("Vertical");

        Debug.Log(leftright);
        if (updown > 0) // Up
        {
            swordrotation = 0;
        }
        if (updown < 0) // Down
        {
            swordrotation = 180;
        }
        if (leftright > 0) // Right
        { 
        
        }
        if (leftright < 0) // Left\
        { 
        
        }


        //transform.rotation = new Vector3 (transform.rotation.x, transform.rotation.y, 
    }
}
