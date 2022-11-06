using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("How fast we will run")]
    [SerializeField] float moveSpeed;

    float horizontalInput;
    float verticalInput;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //Here we check player input and rotate player character if he move to the left
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

    }


    //Phisics calculations - movement and jump
    private void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        rb.velocity = new Vector2(horizontalInput, verticalInput).normalized * moveSpeed;
    }

}
