using UnityEngine;
using System.Collections;

public class characterControlScript : MonoBehaviour {
	public float maxSpeed = 10.0f;
	private bool facingRight = true;
	bool grounded = false;
	public Transform groundCheck;
	public float groundRadius = 0.2f;
	private AudioSource jumpSound;
	public LayerMask whatIsGround;
	public float jumpForce = 700.0f;
	Animator anim;
	private bool movable = false;
	private Vector3 respawn;
	// Use this for initialization
	void Start () {
		//anim = GetComponent<Animator> ();
		//jumpSound = this.GetComponent<AudioSource> ();
		respawn = transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		//anim.SetBool ("Ground", grounded);
		//anim.SetFloat ("vSpeed", GetComponent<Rigidbody2D>().velocity.y);

		if (movable){
			float move = Input.GetAxis ("Horizontal");
			//anim.SetFloat ("Speed", Mathf.Abs (move));
			GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

		}
	}

	void Update()
	{
		if (movable) {
			if (grounded && Input.GetKeyDown (KeyCode.Space)) {
				//anim.SetBool ("Ground", false);
				GetComponent<Rigidbody2D>().AddForce (new Vector2 (0, jumpForce));
				//jumpSound.Play();
			}
		}
		else {
			if (Input.GetKeyDown(KeyCode.Space))
				movable = true;
		}
	}
		
}
