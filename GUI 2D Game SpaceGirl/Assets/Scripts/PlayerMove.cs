using UnityEngine;
using System.Collections;

/*
 * basic 2D character controller
 * use array keys / WASD to move object up/down/left/right
 */
public class PlayerMove : MonoBehaviour
{
	// change speed
	public float spd = 10;

	// cached reference to a physics RigidBody
	private Rigidbody2D rd2D;

	//Initialize by obtain the current scripts attached object's Rigidbody2D
	void Awake()
	{
		rd2D = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()
	{
		// read from movement keys
		// arrow keys / WASD
		// GetAxis returns values between -1.0...0...+1.0
		float xMove = Input.GetAxis("Horizontal");
		float yMove = Input.GetAxis("Vertical");

		// multiply by spd
		float xSpeed = xMove * spd;
		float ySpeed = yMove * spd;

		// create (dx,dy) vector object
		Vector2 newVelocity = new Vector2(xSpeed, ySpeed);

		// set the velocity of the Physicsl rigid body to this (x,y) vector
		rd2D.velocity = newVelocity;
	}
}
