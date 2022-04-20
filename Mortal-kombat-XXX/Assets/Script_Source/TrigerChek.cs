using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerChek : MonoBehaviour
{
    Animator animator;

    [SerializeField] float ChekRadius;


    float WallChekRadius_Up;
    float WallChekRadius_Down;

    [SerializeField] Transform TrigerOnWall_Down;
    [SerializeField] Transform TrigerOnWall_Up;
    [SerializeField] LayerMask Wall;
    
    


    [SerializeField] Transform GroundChek;
    [SerializeField] LayerMask Ground;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        ChekRadius = GroundChek.GetComponent<CircleCollider2D>().radius;
        //WallChekRadius_Up = TrigerOnWall_Up.GetComponent<CircleCollider2D>().radius;
        //WallChekRadius_Down = TrigerOnWall_Down.GetComponent<CircleCollider2D>().radius;
    }
    void Update()
    {

    }
    void FixedUpdate()
    {
        ChekingGround();
        ChekingFall();
        ChekingSlide();
        ChekingDash();
        //OnWall();
        //Cheking_LightAttak();
    }

    public bool ChekingGround()
    {
        bool onGround = Physics2D.OverlapCircle(GroundChek.position, ChekRadius, Ground);      
        animator.SetBool("onGround", onGround);

        return onGround;
    }

    //public bool On_OfJump()
    //{
    //    bool result = 

    //    return result;
    //}

    public bool ChekingFall()
    {
        bool PushSpace = Input.GetKey(KeyCode.Space) ? true : false;
        animator.SetBool("Space_Chek", PushSpace);

        return PushSpace;
    }
    public bool ChekingDash()
    {
        bool PushShift = Input.GetKey(KeyCode.LeftShift) ? true : false;
        animator.SetBool("Shift_Chek", PushShift);

        return PushShift;
    }
    public bool ChekingSlide()
    {
        bool PushCTRL = Input.GetKey(KeyCode.LeftControl) ? true : false;
        animator.SetBool("Ctrl_Chek", PushCTRL);

        return PushCTRL;
       
    }

    

    /*public bool Cheking_LightAttak()
    {
        bool LigthAttak = Input.GetMouseButtonDown(0) ? true : false;
        animator.SetBool("Cheking_LigthAttak", LigthAttak);

        return LigthAttak;
    }


    public bool OnWall()
    {
        bool onWall = Physics2D.OverlapCircle(TrigerOnWall_Down.position, WallChekRadius_Down, Wall) && Physics2D.OverlapCircle(TrigerOnWall_Up.position, WallChekRadius_Up, Wall);
        animator.SetBool("onWall", onWall);

        return onWall;
    }*/

    //public float Time_InLightAttak()
    //{
    //    float AllTime = 5;
    //    float TimeNow = 0;

    //}
}
