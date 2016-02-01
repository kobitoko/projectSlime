using UnityEngine;
using System.Collections;

public class Ranger : MonoBehaviour {
    public PlayerController player;
	//Collider thisCollider;
    public string GameObject_tag;
    public bool inRange;
    public Vector2 TargetPosition;
    
    void Start()
    {
	if (GameObject_tag == null)
	{
	    GameObject_tag = "nothing";
	}
	//thisCollider = GetComponent<Collider>();
	//Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }
    void Update()
    {
	
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
	if (coll.gameObject.tag == GameObject_tag)
	{
	    //Physics.IgnoreCollision(coll,this.collider);
	    //Physics.IgnoreCollision(bullet.GetComponent<Collider>(), );
	    TargetPosition = coll.transform.position;
	    inRange = true;
	    //Debug.Log("Ranger Hit");
	}
    }
    void OnTriggerExit2D(Collider2D coll)
    {
	if (coll.gameObject.tag == GameObject_tag)
	{
	    //Physics.IgnoreCollision(coll,this.collider);
	    //Physics.IgnoreCollision(bullet.GetComponent<Collider>(), );
	    TargetPosition = coll.transform.position;
	    inRange = false;
	    //Debug.Log("Ranger Exit");
	}
    }
}
