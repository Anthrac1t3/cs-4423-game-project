using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float movementSpeed = 3.0f;
    
    Vector2 movement = new Vector2();
    Animator animator;
    string animationState = "AnimationState";
    Rigidbody2D rb2D;

    enum CharStates
    {
        walkEast = 1,
        walkSouth = 2,
        walkWest = 3,
        walkNorth = 4,
        idleEast = 5,
        idleSouth = 6,
        idleWest = 7,
        idleNorth = 8
    }

    CharStates prevState = CharStates.idleSouth;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateState();
    }

    void FixedUpdate()
    {
        MoveCharacter();
    }

    private void MoveCharacter()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement.Normalize();
        rb2D.velocity = movement * movementSpeed;
    }

    private void UpdateState()
    {
        CharStates newState = prevState;
        if (movement.x > 0)
            newState = CharStates.walkEast;
        else if (movement.x < 0)
            newState = CharStates.walkWest;
        else if (movement.y > 0)
            newState = CharStates.walkNorth;
        else if (movement.y < 0)
            newState = CharStates.walkSouth;
        else
        {
            switch (prevState) {
                case CharStates.walkEast:
                    newState = CharStates.idleEast;
                    break;
                case CharStates.walkWest:
                    newState = CharStates.idleWest;
                    break;
                case CharStates.walkSouth:
                    newState = CharStates.idleSouth;
                    break;
                case CharStates.walkNorth:
                    newState = CharStates.idleNorth;
                    break;
            }
        }

        // if (newState != prevState) {
            animator.SetInteger(animationState, (int) newState);
            prevState = newState;
        // }
    }
}
