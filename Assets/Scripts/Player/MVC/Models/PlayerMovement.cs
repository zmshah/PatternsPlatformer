using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float runspeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }else if(Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }       
    }

    // void OnTriggerEnter2D(Collision2D other)
    //{
    //    if (other.gameObject.CompareTag("Coins"))
    //    {
    //        Destroy(other.gameObject);
    //    }
    //}


    // player collects the coins
    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag.Equals("Enemy"))
    //    {
    //        gameObject.SetActive(false);
    //    }
    //}


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Destroy(gameObject);
            SnapshotOriginator originator = new SnapshotOriginator(ScoreBoard.shared.GetPoints());
            ScoreKeeper caretaker = new ScoreKeeper(originator);

            caretaker.RecordScore();
            LevelManager.instance.Respawn();
        }
    }

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.gameObject.tag.Equals("Player"))
    //    {
    //        gameObject.SetActive(false);
    //        //Destroy(gameObject);
    //    }
    //}

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
