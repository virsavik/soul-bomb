using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;

    Vector2 move;

    SpriteRenderer spriteRenderer;

    private Animator anim;
    private enum MovementState { idle, running, jumping, falling };

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxis("Horizontal");
        UpdateAnimatorState();
    }

    private void UpdateAnimatorState() {
        MovementState state;

        if (move.x < 0f) {
            state = MovementState.running;
            spriteRenderer.flipX = true;
        } else if (move.x > 0f) {
            state = MovementState.running;
            spriteRenderer.flipX = false;
        } else {
            state = MovementState.idle;
        }

        anim.SetInteger("state", (int)state);
    }

}
