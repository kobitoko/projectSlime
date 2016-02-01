using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
    {
    public GameObject Target;
    private float xoffset;
    private float yoffset;
    private float zoffset;
    public float rotateSpeed;

    // Use this for initialization
    void Start()
        {

        Target = GameObject.FindGameObjectWithTag("Player");
        xoffset = 0f;
        yoffset = 5f;
        zoffset = -15f;
        rotateSpeed = 5f;
        }

    // Update is called once per frame
    void LateUpdate()
        {

        transform.position = new Vector3(Target.transform.position.x + xoffset, Target.transform.position.y + yoffset, Target.transform.position.z + zoffset);
        float rot = Input.GetAxis("CameraRotate");
        //transform.RotateAround(Target.transform.position, Vector3.up, rot * rotateSpeed * Time.deltaTime);
        //transform.Translate(Vector3.right * rot * rotateSpeed * Time.deltaTime);
         
        transform.LookAt(Target.transform);
        }
    }
