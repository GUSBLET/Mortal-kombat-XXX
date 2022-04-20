using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Plaeyr : MonoBehaviour
{
    TrigerChek trigerChek;
    Rigidbody2D rb;
    Vector2 moveVector;
    Animator animator;
    //StaminaInformation stamina;

    float moveSpeed = 9.0f;



    //Reflect variable
    bool faceRight = true;


    //variable for jump
    float jumpForce = 80f;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        trigerChek = GetComponent<TrigerChek>();
        //stamina = GetComponent<StaminaInformation>();
    }

    private void FixedUpdate()
    {
        Run();
        Reflect();
        Jump();
        //Slide();
        //Dash();
    }




    void Run()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveVector.x * moveSpeed, rb.velocity.y);

        animator.SetFloat("moveX", Mathf.Abs(moveVector.x));
    }

    void Reflect()
    {
        if ((moveVector.x > 0 && !faceRight) || (moveVector.x < 0 && faceRight))
        {
            transform.localScale *= new Vector2(-1, 1);
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, 1);
            faceRight = !faceRight;


            if (faceRight) transform.position = new Vector3(transform.position.x + 0.8f, transform.position.y, 0);
            else if (!faceRight) transform.position = new Vector3(transform.position.x - 0.8f, transform.position.y, 0);
        }
    }
    void Jump()
    {
        
        if (trigerChek.ChekingGround() && Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
        
    }
    
    /*void Slide()
    {
        if (Mathf.Abs(moveVector.x) > 0.1 && !trigerChek.ChekingDash()  && trigerChek.ChekingGround() && stamina.Stamina_Slide())
        {
            if (trigerChek.ChekingSlide() && !faceRight) rb.AddForce(Vector2.left * 250);
            else if (trigerChek.ChekingSlide() && faceRight) rb.AddForce(Vector2.right * 250);
        }
    }

    void Dash()
    {
        if (Mathf.Abs(moveVector.x) > 0.1 && !trigerChek.ChekingSlide() && trigerChek.ChekingGround() && stamina.Stamina_Dash())
        {
            if (trigerChek.ChekingDash() && !faceRight) rb.AddForce(Vector2.left * 300);
            else if (trigerChek.ChekingDash() && faceRight) rb.AddForce(Vector2.right * 300);
        }
    }*/

}
