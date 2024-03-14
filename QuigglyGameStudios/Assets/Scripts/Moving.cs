using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{

    private float leftright;
    private float updown;
    private Rigidbody2D rb;
    public float Speed = 5;

    [SerializeField] private float dodgespeed;
    public float dodge_invincibility_time = 0.5f;
    public float dodge_again_time = 1.5f;
    private float timer = 0;

    [SerializeField] private bool hasDodged = false;
    public bool dodgeInvincibility = false;
    


    public GameObject sword;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftShift) && hasDodged == false)
        {
            Debug.Log("Dodge works!");
            Dodge();
        }
    }
    void Update()
    {
        // getting the player input
        leftright = Input.GetAxis("Horizontal");
        updown = Input.GetAxis("Vertical");

        // Adding speed to velocity depending on the player input.

        rb.velocity = new Vector2(leftright * Speed, updown * Speed);
        
        if (hasDodged)
        {
            timer += Time.deltaTime;

            if (timer >= dodge_invincibility_time)
            {
                dodgeInvincibility = false;
            }
            if (timer >= dodge_again_time)
            {
                hasDodged = false;
                timer = 0;
            }
        }
        
        // Debug.Log(Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            sword.SetActive(true);
            sword.GetComponent<SwingSword>().Attack();
        }

        


    }
    void Dodge()
    {
        hasDodged = true;
        dodgeInvincibility = true;
        rb.velocity = new Vector2(leftright * dodgespeed, updown * dodgespeed);
    }
}
