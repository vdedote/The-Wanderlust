using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : Character {

    private Rigidbody2D myRigidBody;

    //private Animator myAnimator;

    //[SerializeField]
    //private float movementSpeed;

    //private bool facingRight;

    
    private float direction;

    //This is for the ladder
    //private float verticalMovement;
    //public float distance;
    //public LayerMask whatIsLadder;
    //private bool isCLimbing;

    private bool move;

    // Use this for initialization
    public override void Start()
    {
        //facingRight = true;

        //This is how you will get a reference to the rigidbody
        //inside unity to the script
        base.Start();
        myRigidBody = GetComponent<Rigidbody2D>();
        //myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        if (move)
        {
            HandleMovement(direction);
            Flip(direction);
        }
        else
        {
            HandleMovement(horizontal);

            Flip(horizontal);
        }

        //RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, distance, whatIsLadder);

        //if (hitInfo.collider != null)
        //{
        //    if (Input.GetKeyDown(KeyCode.UpArrow))
        //    {
        //        isCLimbing = true;
        //    }
        //}
        //else
        //{
        //    isCLimbing = false;
        //}

        //if (isCLimbing == true)
        //{
        //    verticalMovement = Input.GetAxisRaw("Vertical");
        //    myRigidBody.velocity = new Vector2(myRigidBody.position.x, verticalMovement * movementSpeed);
        //    myRigidBody.gravityScale = 0;
        //}
        //else
        //{
        //    myRigidBody.gravityScale = 1;
        //}

    }

    private void HandleMovement(float horizontal)
    {
        //This will handle of the movements of the player throughout the Game
        myRigidBody.velocity = new Vector2(horizontal * movementSpeed, myRigidBody.velocity.y);

        myAnimator.SetFloat("speed", Mathf.Abs(horizontal));
    }

    private void Flip(float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {

            ChangeDirection();
            //facingRight = !facingRight;

            //Vector3 theScale = transform.localScale;

            //theScale.x *= -1;

            //transform.localScale = theScale;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Objective")
        {
            //Destroy(other.gameObject);
        }
    }

    public void WalkMove(float direction)
    {
        this.direction = direction;
        this.move = true;
    }

    public void StopMoveBtn()
    {
        this.direction = 0;
        move = false;
    }


}
