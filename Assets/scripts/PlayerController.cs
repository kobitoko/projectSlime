using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public GameObject prefab;
    public GUIArrow guiArrow;
    public float slow_speed;
    private Rigidbody2D rb;
    private bool ActionSucking;
    public float max_speed;
    public float speed;
    public int slime_count;
    public int max_slime;
    public bool hasJar;
    public int throwStrength;
    private bool facingRight;
    Animator anim;
    public Animator wind;
    // Use this for initialization
    void Start ()
	{
	hasJar = false;
	ActionSucking = false;
	rb = GetComponent<Rigidbody2D>();
	anim = GetComponent<Animator>();
	//rb.velocity.Set(5, 5);
    }
    //
    // Update is called once per frame
    void FixedUpdate ()
	{
	//slime_count = 0;
        float moveV;
	float moveH;


	moveV = Input.GetAxis("Vertical");
	moveH = Input.GetAxis("Horizontal");

	anim.SetFloat("vel Y", moveV);
	anim.SetFloat("vel X", moveH);
	if (moveH < 0 && !facingRight)
	    Flip();
	else if (moveH > 0 && facingRight)
	    Flip();
	anim.SetBool("hasJar", hasJar);

	if (slime_count>0)
	{
	    anim.SetBool("jarIsFull",true );
	}
	else
	{
	    anim.SetBool("jarIsFull", false);
	}

	if (max_speed > speed)
	{
	    speed++;
	}
	


	moveV = moveV * speed * Time.deltaTime;
	moveH = moveH * speed * Time.deltaTime;
	Vector2 move = new Vector2(moveH, moveV);
	//rb.AddForce(move);
	rb.velocity = move;
	}
    void Update()
    {
	if (hasJar)
	{
	    if (Input.GetMouseButtonDown(1))//left
	    {
		//Debug.Log("Left Down");
		//pickupBox.transform.
		ActionSucking = true;

		wind.SetBool("on",true);
            }
	    else
	    {
		if (Input.GetMouseButtonUp(1))
		{
		    //Debug.Log("Left Up");
		    ActionSucking = false;
		    wind.SetBool("on", false);
		}
	    }
	    if (Input.GetMouseButtonDown(0))//Right
	    {
		//Debug.Log("Right");
		if (slime_count > 0)
		{

		    //Debug.Log("Making Slime");
		    Vector3 v3Pos;
		    float angle;
                    v3Pos = Camera.main.WorldToScreenPoint(transform.position);
		    v3Pos = Input.mousePosition - v3Pos;
		    angle = Mathf.Atan2(v3Pos.y, v3Pos.x) * Mathf.Rad2Deg;


		    GameObject obj = (GameObject)Instantiate
			(
			prefab,
			(rb.position+ getVector(angle,3)),
			Quaternion.Euler(0f, 0f, angle)
			);
		    //Rigidbody2D rb2d = obj.GetComponent<Rigidbody2D>();
		    obj.GetComponent<Rigidbody2D>().velocity = getVector(angle, throwStrength);
                    Debug.Log("Right: Angle to player:" + angle);
		    slime_count--;

		}
	    }
	}
    }
    public void slow()
    {
	speed -= slow_speed;
    }
    void OnTriggerStay2D(Collider2D col)
    {
	if ((ActionSucking == true) && (col.gameObject.tag == "slime"))
	{
	    if (max_slime> slime_count)
	    {
		if (col.gameObject != null)
		{
		    Destroy(col.gameObject);
		    slime_count++;
		}
	    }
	}
	
    }
    void OnCollisionEnter2D(Collision2D col)
    {
	if (col.gameObject.tag=="jar")
	{
	    guiArrow.setVisibility(true);
	    hasJar = true;
	    Destroy(guiArrow.gameObject);
            Destroy(col.gameObject);

	}
    }
    public float getAngle(Vector2 a , Vector2 b)
    {
	Vector2 diff = b - a;
	diff.Normalize();
	return Mathf.Atan2(diff.y,diff.x)*Mathf.Rad2Deg;
    }
    public Vector2 getVector(float angle , float radius)
    {
	return new Vector2(
	    radius * Mathf.Cos(Mathf.Deg2Rad * angle),
	    radius * Mathf.Sin(Mathf.Deg2Rad * angle)
	    );
    }

    void Flip()
    {
	facingRight = !facingRight;
	Vector3 theScale = transform.localScale;
	theScale.x *= -1;
	transform.localScale = theScale;
    }
}
