using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 5;

    public bool isDamaged = false;
    public float isDamagedTimer = 0.5f;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        if (isDamaged)
        {
            timer += Time.deltaTime;
            if (timer >= isDamagedTimer)
            {
                isDamaged = false;
            }
        }
    }

    public void TakeDamage(int amount)
    {

        if (isDamaged == false)
        {
            if (GetComponent<Moving>() != null)
            {
                if (GetComponent<Moving>().dodgeInvincibility == false)
                {
                    health -= amount;
                    isDamaged = true;
                    if (health <= 0)
                    {
                        Destroy(gameObject);
                    }
                }
            }
            else
            {
                health -= amount;
                if (health <= 0)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
