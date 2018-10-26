using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    public float speed = 10;
    private Rigidbody2D rdby2D;

	// Use this for initialization
	void Awake () {
        rdby2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //detects directional for LEFT and RIGHT arrow key input
        float xMove = Input.GetAxis("Horizontal");

        //detects directional for UP and DOWN arrow key input
        float yMove = Input.GetAxis("Vertical");

        float xSpeed = xMove * speed;
        float ySpeed = yMove * speed;

        Vector2 newVelocity = new Vector2(xSpeed, ySpeed);

        rdby2D.velocity = newVelocity;
	}
}
