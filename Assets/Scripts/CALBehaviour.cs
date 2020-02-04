using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CALBehaviour : MonoBehaviour
{
    public Animator Anim;
    public float HorizontalAxis;
    public float VerticalAxis;  
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Anim.SetTrigger("Attack1");

        HorizontalAxis = Input.GetAxis("Horizontal");
        VerticalAxis = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.RightArrow))
            Anim.SetBool("isMoving", true);
       
        else
            Anim.SetBool("isMoving", false);

               
        
    }
}
