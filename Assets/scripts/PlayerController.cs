using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Rigidbody2D rb;
    public float speed;
	// Use this for initialization
	void Start ()
	{
	
		rb = GetComponent<Rigidbody2D>();
		//rb.velocity.Set(5, 5);
	}
    //
    // Update is called once per frame
    void FixedUpdate ()
	{

	float moveV;
	float moveH;
	moveV = Input.GetAxis("Vertical") * speed * Time.deltaTime;
	moveH = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
	Vector2 move = new Vector2(moveH, moveV);
	//rb.AddForce(move);
	rb.velocity = move;
	}
}
