using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool controlEnabled = true;
    Vector2 move;

    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controlEnabled) {
            move.x = Input.GetAxis("Horizontal");
        }
        else {
            move.x = 0;
        }
        ComputeVelocity();
    }

    private void ComputeVelocity(){
        if (move.x > 0.01f){
            spriteRenderer.flipX = false;
        } else if (move.x < -0.01f) {
            spriteRenderer.flipX = true;
        }
    }
}
