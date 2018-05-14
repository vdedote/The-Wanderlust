using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dog : MonoBehaviour {

    private Rigidbody2D myRigidBody;

    private Animator myAnimator;

    [SerializeField]
    private float movementSpeed;

    private bool facingRight;

    private float direction;

    private bool move;

    private float Horizontalbtn;

    // Use this for initialization
    void Start()
    {
        facingRight = true;

        //This is how you will get a reference to the rigidbody
        //inside unity to the script
        myRigidBody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        if (move)
        {
            //this.Horizontalbtn = Mathf.Lerp(Horizontalbtn, direction, Time.deltaTime * 2);  
            HandleMovement(direction);
            Flip(direction);
        }
        else
        {
            HandleMovement(horizontal);

            Flip(horizontal);
        }

     

       


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
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;
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
