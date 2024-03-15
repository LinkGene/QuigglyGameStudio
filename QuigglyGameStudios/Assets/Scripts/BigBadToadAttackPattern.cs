using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBadToadAttackPattern : MonoBehaviour
{
    public Animator animator;
    private int rannum;

    private Vector3 tungrotation;

    [SerializeField] private float jumpAttackIntervalMin;
    [SerializeField] private float jumpAttackIntervalMax;
    private float jumpAttackInterval = 10f;
    private float jumpAttackTimer = 0f;
    private bool isJumpAttack = false;

    [SerializeField] private float tungAttackIntervalMin;
    [SerializeField] private float tungAttackIntervalMax;
    private float tungAttackInterval = 30f;
    private float tungAttackTimer = 0f;
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
        Debug.Log("Jump Attack");
        animator.SetTrigger("JumpAttack");
    }
    void TungAttack()
    {
        animator.SetTrigger("TungAttack");
    }

    // Update is called once per frame
    void Update()
    {

        jumpAttackTimer += Time.deltaTime;
        tungAttackTimer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.G))
        {
            JumpAttack();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            TungAttack();
        }

        if (jumpAttackTimer >= jumpAttackInterval && isTungAttack == false)
        {
            JumpAttack();
            SetJumpAttackInterval();
            jumpAttackTimer = 0f;
        }

        if (tungAttackTimer >= tungAttackInterval && isJumpAttack == false)
        {
            TungAttack();
            SetTungAttackInterval();
            tungAttackTimer = 0f;
        }
    }

    public void MoveToCorner()
    {
        rannum = Random.Range(1, 5);
        switch (rannum)
        {
            case 1: // Top Left
                transform.position = new Vector3(-7f, 3.5f, transform.position.z);
                tungrotation.z = -90.0f;
                transform.rotation = Quaternion.Euler(tungrotation);

                break;
            case 2: // Top Right
                transform.position = new Vector3(7f, 3.5f, transform.position.z);
                tungrotation.z = 180.0f;
                transform.rotation = Quaternion.Euler(tungrotation);
                break;
            case 3: // Bottom Left
                transform.position = new Vector3(-7f, -3.5f, transform.position.z);
                tungrotation.z = 0f;
                transform.rotation = Quaternion.Euler(tungrotation);
                break;
            case 4: // Bottom Right
                transform.position = new Vector3(7f, -3.5f, transform.position.z);
                tungrotation.z = 90.0f;
                transform.rotation = Quaternion.Euler(tungrotation);

                // code
                break;
        }
    }
}
