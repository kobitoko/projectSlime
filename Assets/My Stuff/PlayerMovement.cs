using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed;
	// Use this for initialization
	void Start () {

        moveSpeed = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.position += new Vector3(h * moveSpeed, 0, v * moveSpeed);
	}
}
