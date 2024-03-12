using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{

    private float leftright;
    private float updown;
    private Rigidbody2D rb;
    public float SPEED = 5;

    public GameObject sword;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // getting the player input
        leftright = Input.GetAxis("Horizontal");
        updown = Input.GetAxis("Vertical");

        // Adding speed to velocity depending on the player input.

        rb.velocity = new Vector2(leftright * SPEED, updown * SPEED);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            sword.SetActive(true);
            sword.GetComponent<SwingSword>().Attack();
        }




    }
}
