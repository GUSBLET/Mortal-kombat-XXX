//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class StaminaInformation : MonoBehaviour
//{
//    [SerializeField] Slider stamina_Slide;
//    [SerializeField] Slider stamina_Dash;
//    Animator animator;
//    TrigerChek trigerChek;
//    void Start()
//    {
//        trigerChek = GetComponent<TrigerChek>();
//        animator = GetComponent<Animator>();
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//    private void FixedUpdate()
//    {
//        Stamina_Dash();
//        Stamina_Slide();
//    }

//    public bool Stamina_Slide()
//    {
//        if (!trigerChek.ChekingSlide() || !animator.GetBool("onGround"))
//        {
//            stamina_Slide.value += 3 * Time.deltaTime;
//        }
//        else if (!trigerChek.ChekingDash() && trigerChek.ChekingSlide() && animator.GetBool("onGround"))
//        {
//            stamina_Slide.value -= 4.5f * Time.deltaTime;
//        }
//        bool Value = stamina_Slide.value != 0 ? true : false;
//        Value = !trigerChek.ChekingSlide() ? false : Value;
        
//        animator.SetBool("Stamina_Slide", Value);
       

//        return Value;
//    }

//    public bool Stamina_Dash()
//    {
//        if (!trigerChek.ChekingDash() || !animator.GetBool("onGround"))
//        {
//            stamina_Dash.value += 2.5f * Time.deltaTime;
//        }
//        else if (!trigerChek.ChekingSlide() && trigerChek.ChekingDash() && animator.GetBool("onGround"))
//        {
//            stamina_Dash.value -= 9f * Time.deltaTime;
//        }
//        bool Value = stamina_Dash.value != 0 ? true : false;
//        Value = !trigerChek.ChekingDash() ? false : Value;

//        animator.SetBool("Stamina_Dash", Value);


//        return Value;
//    }

//}

