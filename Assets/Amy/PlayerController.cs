using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //[SerializeField] float speed = 1;
    [SerializeField] float forceX = 1;
   // [SerializeField] float forceY = 1;
    Rigidbody2D rb;
   // bool onGround = false;
    Animator animator; //declare variable
   // SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>(); //declare component
       // spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(forceX * Vector2.right);
            //animator.SetBool("WalkRight", true);
        }
           /* else
            {
                animator.SetBool("IdleFront", true);
            }
        if (Input.GetKey(KeyCode.Space)) 
        {
            rb.AddForce(forceY * Vector2.up);
        }
*/
    }
}

