using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour {

	public float topSpeed = 10f;
	bool facingRight = true;

	// get reference to animator
	 Animator anim;

	bool grounded = false;
	public float speed;
	public float jump;
	float moveVelocity;

	public Transform GroundCheck;

	float groundRadius = 0.2f;

	public float jumpForce = 700f;
	public LayerMask whatIsGround;


	void FixedUpdate (){
		grounded = Physics2D.OverlapCircle (GroundCheck.position, groundRadius, whatIsGround); 

		//anim.SetBool ("ground", grounded);
		//anim.SetFloat ("vSpeed", GetComponent<Rigidbody2D>().velocity.y); 

		float move = Input.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (move * topSpeed, GetComponent<Rigidbody2D> ().velocity.y);

		//anim.SetFloat ("speed", Mathf.Abs (move));

		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();
	}
			 
	void Update (){			
		if (grounded && Input.GetKeyDown (KeyCode.Space)) {
			anim.SetBool ("ground", false);

			GetComponent<Rigidbody2D>().AddForce (new Vector2 (0, jumpForce)); 
		} 

		if (Input.GetKeyDown (KeyCode.Space) ||
			Input.GetKeyDown (KeyCode.W)) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2(
				GetComponent<Rigidbody2D> ().velocity.x, jump);
		}

	}

	void Flip (){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;

		theScale.x *= -1;

		transform.localScale = theScale;
	}
}

