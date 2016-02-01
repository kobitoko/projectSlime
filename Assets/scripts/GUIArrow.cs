using UnityEngine;
using System.Collections;

public class GUIArrow : MonoBehaviour {
    public float radius;
    Vector2 cameraPosition;
    Vector2 centreScreen;
    public Camera cam;
    public Rigidbody2D rb_from;
    public Rigidbody2D rb_to;
	// Use this for initialization
    void Start ()
    {
	transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2));
	transform.position += new Vector3(0,0,1);

    }
	
    public void setVisibility(bool i)
    {
	if (i == true)
	{
	    transform.position += new Vector3(0, 0, 0.5f);
	}
	else
	{
	    transform.position += new Vector3(0, 0, 10);
	}
    }
	void FixedUpdate ()
    {

	Vector2 grg = rb_to.position - rb_from.position;
	grg.Normalize();
	float rot = Mathf.Atan2(grg.y, grg.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot);

    }
}


