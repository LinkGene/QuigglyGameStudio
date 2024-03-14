using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 5;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        if (GetComponent<Moving>() != null)
        {
            if (GetComponent<Moving>().dodgeInvincibility == false)
            {
                health -= amount;
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
