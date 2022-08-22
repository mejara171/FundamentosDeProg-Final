using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Frog : Enemy
{
    [SerializeField] private float leftCap;
    [SerializeField] private float rightCap;

    [SerializeField] private float jumpLength = 10f;
    [SerializeField] private float JumpHeight = 15f;
    [SerializeField] private LayerMask ground; 
    private Collider2D coll;

    private bool facingLeft = true;

    protected override void Start()
    {
        base.Start();
       coll = GetComponent<Collider2D>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (facingLeft)
        {
            if (transform.position.x > leftCap)
            {
                //make sure sprite is facing right location, and if it is not, them face the rifht direction
                if (transform.localScale.x != 1)
                {
                    transform.localScale = new Vector3(1, 1);
                }


                //Test to see if I am on the ground, if so jump
                if (coll.IsTouchingLayers(ground))
                {
                    //Jump
                    rb.velocity = new Vector2(-jumpLength, JumpHeight);
                }
            }
            else
            {
                facingLeft = false;
            }

        }
        //if it is not, we are going to face Right
        else
        {
            if (transform.position.x < rightCap)
            {
                //make sure sprite is facing right location, and if it is not, them face the rifht direction
                if (transform.localScale.x != -1)
                {
                    transform.localScale = new Vector3(-1, 1);
                }


                //Test to see if I am on the ground, if so jump
                if (coll.IsTouchingLayers(ground))
                {
                    //Jump
                    rb.velocity = new Vector2(jumpLength, JumpHeight);
                }
            }
            else
            {
                facingLeft = true;
            }

        }
    }



}
