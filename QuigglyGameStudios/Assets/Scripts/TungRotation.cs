using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TungRotation : MonoBehaviour
{
    // The target marker.
    public Transform target;

    // Angular speed in radians per sec.
    public float speed = 1.0f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += target.position * speed / 2; // Move the object in the direction of scaling, so that the corner on ther side stays in place
        transform.localScale += target.position * speed; // Scale object in the specified direction
    }
}
