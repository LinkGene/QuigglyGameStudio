using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBadToadAttackPattern : MonoBehaviour
{
    public Animator animator;
    private int rannum;

    [SerializeField] private float jumpAttackIntervalMin;
    [SerializeField] private float jumpAttackIntervalMax;
    private float jumpAttackInterval;
    private float jumpAttackTimer;
    private bool isJumpAttack = false;

    [SerializeField] private float tungAttackIntervalMin;
    [SerializeField] private float tungAttackIntervalMax;
    private float tungAttackInterval;
    private float tungAttackTimer;
    private bool isTungAttack = false;

    void SetJumpAttackInterval()
    {
        jumpAttackInterval = Random.Range(jumpAttackIntervalMin, jumpAttackIntervalMax);
    }

    public void ToggleIsJumpAttack()
    {
        if (isJumpAttack)
        {
            isJumpAttack = false;
        }
        else
        {
            isJumpAttack = true;
        }
    }

    public void ToggleIsTungAttack()
    {
        if (isTungAttack)
        {
            isTungAttack = false;
        }
        else
        {
            isTungAttack = true;
        }
    }

    void SetTungAttackInterval()
    {
        tungAttackInterval = Random.Range(tungAttackIntervalMin, tungAttackIntervalMax);
    }

    void JumpAttack()
    {
        animator.SetTrigger("JumpAttack");
    }
    void TungAttack()
    {
        //animator.SetTrigger("TungAttack");
    }

    // Update is called once per frame
    void Update()
    {

        jumpAttackTimer += Time.deltaTime;
        tungAttackTimer += Time.deltaTime;

        if (jumpAttackTimer >= jumpAttackInterval && isTungAttack == false)
        {
            JumpAttack();
            jumpAttackTimer = 0f;
        }

        if (tungAttackTimer >= tungAttackInterval && isJumpAttack == false)
        {
            TungAttack();
            tungAttackTimer = 0f;
        }







        if (Input.GetKeyDown(KeyCode.G))
        {
            JumpAttack();
        }
    }

    public void MoveToCorner()
    {
        rannum = Random.Range(1, 5);
        switch (rannum)
        {
            case 1: // Top Left
                transform.position = new Vector3(-7f, 3.5f, transform.position.z);
                break;
            case 2: // Top Right
                transform.position = new Vector3(7f, 3.5f, transform.position.z);
                break;
            case 3: // Bottom Left
                transform.position = new Vector3(-7f, -3.5f, transform.position.z);
                break;
            case 4:
                transform.position = new Vector3(7f, -3.5f, transform.position.z);
                // code
                break;
        }
    }
}
