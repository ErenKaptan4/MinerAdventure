using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Animator animate;
    private Rigidbody2D myRigidbody;
    private SpriteRenderer sprite;
    private BoxCollider2D myCollider;

    private float xVal = 0;

    [SerializeField] private LayerMask jumpFromGround;
    [SerializeField] float speed = 7f;
    [SerializeField] float jump = 5f;

    private enum MovementType {idle, running, jumping, falling}

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        animate = GetComponent<Animator>();

    }


    private void Update()
    {
        this.transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
        //jump and move to sides
        xVal = Input.GetAxisRaw("Horizontal");
        myRigidbody.velocity = new Vector2(xVal * speed, myRigidbody.velocity.y);

        //if player hit the ground and press jump (if both true, jump)
        if (Input.GetButtonDown("Jump") && playerOnGround())
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jump);
        }

        AnimationState();
    }

    private void AnimationState()
    {
        MovementType curState;

        //if running or standing
        if (xVal > 0f)
        {
            curState = MovementType.running;
            sprite.flipX = false;
        }
        else if (xVal < 0f)
        {
            curState = MovementType.running;
            sprite.flipX = true;
        }
        else
        {
            curState = MovementType.idle;
        }

        //if jumping or fall
        if(myRigidbody.velocity.y > .1f)
        {
            curState = MovementType.jumping;
        }
        else if (myRigidbody.velocity.y < -.1f)
        {
            curState = MovementType.falling;
        }

        //turns enum into corresponding int
        animate.SetInteger("playerState", (int)curState);
    }

    
    private bool playerOnGround()
    {
        //created another hitbox around the player
        return Physics2D.BoxCast(myCollider.bounds.center, myCollider.bounds.size, 0f, Vector2.down, .1f, jumpFromGround);
    }
}
