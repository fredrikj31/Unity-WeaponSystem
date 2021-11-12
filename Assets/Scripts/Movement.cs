using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	[SerializeField] float jumpForce;
	[SerializeField] float speed;
	Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		if (Input.GetButtonDown("Jump"))
		{
			rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
		}
	}

	void FixedUpdate()
	{
		float x = Input.GetAxis("Horizontal");
		Vector3 move = new Vector3(x * speed, rb.velocity.y, 0f);
		rb.velocity = move;
	}
}
