using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExperimentScript : MonoBehaviour {

    

    private Rigidbody2D myRigidbody;
    private Animator myAnimator;

    private float inputHorizontal;
    public float speed;
    private bool facingRight;

    //THIS IS FOR CLIMBING THE LADDER
    private float inputVertical;
    public float distance;
    public LayerMask whatIsLadder;
    private bool isClimbing;
    private bool climbing;

    
    //for the buttons
    private float direction;
    private bool move;
    private float btnHorizontal;

	// Use this for initialization
	void Start ()
    {
        facingRight = true;
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        
        //for Flipping the character
        Flip(inputHorizontal);
        ClimbLadder();

        if (move)
        {
            this.btnHorizontal = Mathf.Lerp(btnHorizontal, direction, Time.deltaTime * 1);
            HandleMovement(btnHorizontal);
            Flip(direction);
        }
        else
        {
            HandleMovement(inputHorizontal);
        }
        
        
	}

    private void HandleMovement(float inputHorizontal)
    {
        //for Walking
        myRigidbody.velocity = new Vector2(inputHorizontal * speed, myRigidbody.velocity.y);
        myAnimator.SetFloat("speed", Mathf.Abs(inputHorizontal));
    }

    private void ClimbLadder()
    {
        //this is for the climbing of ladder
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, distance, whatIsLadder);

        if (hitInfo.collider != null)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                isClimbing = true;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                isClimbing = false;

            }

        }

        if (isClimbing == true && hitInfo.collider != null)
        {
            inputVertical = Input.GetAxisRaw("Vertical");
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, inputVertical * speed);
            myRigidbody.gravityScale = 0;
            myAnimator.SetTrigger("climb");
        }
        else
        {
            myRigidbody.gravityScale = 1;
        }
    }

    private void Flip(float inputHorizontal)
    {
        if (inputHorizontal > 0 && !facingRight || inputHorizontal < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;
        }
    }

    public void ButtonWalk(float direction)
    {
        this.direction = direction;
        this.move = true;
    }

    public void ButtonStopWalk()
    {
        this.direction = 0;
        this.btnHorizontal = 0;
        this.move = false;
    }


    public void ButtonClimb()
    {
        ClimbLadder();
    }
}
