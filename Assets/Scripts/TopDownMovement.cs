using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Setup")]
    public float moveSpeed;
    Rigidbody2D rb;
    [NonSerialized]
    public bool canMove = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, Input.GetAxisRaw("Vertical") * moveSpeed);   
    }
}
