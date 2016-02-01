using UnityEngine;
using System.Collections;

public class Slime : MonoBehaviour {

    public Ranger Range;
    public Rigidbody2D rb;
    public Vector2 nextPosition;
    public Vector2 [] possibleMoves;
    public int act;//on act =0 then the slime will do something.
    public int maxAct;
    public bool agressive;
    public float speed;
    public float timeToHit;
    bool hasTarget;
    public float radius;
    public float pullStrength;
    // Use this for initialization
    void Start()
    {

	rb = GetComponent<Rigidbody2D>();
	Vector2 [] Moves = 
	    {
		new Vector2(1,0),
		new Vector2(0, 1),
		new Vector2(1, 1),
		new Vector2(-1, 0),
		new Vector2(0, -1),
		new Vector2(-1, -1)
	    };
	possibleMoves = Moves;
        Debug.Log(possibleMoves.Length);

	Physics2D.IgnoreCollision(Range.GetComponent<Collider2D>(), GetComponent<Collider2D>());
	
    }

    // Update is called once per frame
    void Update()
    {
	if (Range.inRange==true)
	{
	    nextPosition = (Range.TargetPosition - rb.position)/ (timeToHit* timeToHit);
	    nextPosition.x = nextPosition.x * speed * rb.mass;
	    nextPosition.y = nextPosition.y * speed * rb.mass;
	    if (agressive == true || act <= 0 )
	    {
		rb.AddForce(nextPosition);
	    }
	}
	else
	{
            if (act <= 0)//if action move randomly
	    {
		int i = Random.Range(0, possibleMoves.Length);

		//Debug.Log("Slime Moves Randomly" + i + " or Vector ");//+possibleMoves[i].ToString());
		nextPosition = possibleMoves[i];
		nextPosition.x = nextPosition.x * speed * rb.mass;
		nextPosition.y = nextPosition.y * speed * rb.mass;

		rb.AddForce(nextPosition);

		act = maxAct;
	    }

	}
	act -= 1;
	Range.transform.position = rb.position;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
	if (col.gameObject.tag == "Player")
	{
	    Debug.Log("Deaded");
	    col.gameObject.GetComponent<Rigidbody2D>().AddForce(rb.velocity);
		
        }
    }
    void Move()
    {
	
    }
}
