using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingSword : MonoBehaviour
{
    public GameObject Sword;
    public Animator animator;
    public bool hasSwung = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("Idle") && hasSwung == true)
        {
            hasSwung = false;
            DoneSwinging();
        }
    }

    public void Attack()
    {
        // play animate of atack
        animator.SetTrigger("SwingSword");
        hasSwung = true;
        // detect enemy and do Damage
    }
    void DoneSwinging()
    {
        Sword.SetActive(false);
    }
}
