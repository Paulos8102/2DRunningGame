//PaulJabez_LevelGame2D
//For player movement

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;

    [SerializeField] private LayerMask jumpableGround;

    [SerializeField] private AudioSource jumpSoundEffect;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
    }


    private void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && IsGrounded())  //To avoid flying when space is held on for long
        {
            jumpSoundEffect.Play();
            rb.velocity = new Vector2(rb.velocity.x, 10f);    //setting speed for player
        }
    }
    private bool IsGrounded()   //to be able to jump only when above the ground
    {
        //creating a new box and checking if it overlaps with the ground

        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
