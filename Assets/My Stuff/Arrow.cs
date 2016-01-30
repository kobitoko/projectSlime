using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Arrow : MonoBehaviour {

    public GameObject Target;
    public Camera theCamera;
    public GameObject ApointingArrow;

	// Use this for initialization
	void Start () {
        Target = GameObject.FindGameObjectWithTag("Target");
        theCamera = Camera.main;
        Instantiate(ApointingArrow, new Vector3(321.5f, 304.5f, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
         Vector3 screenPosition = theCamera.WorldToScreenPoint(Target.transform.position);
        if (screenPosition.z < 0)
            {
            screenPosition *= -1;
            }
        Vector3 ScreenCenter = new Vector3(Screen.width, Screen.height, 0) / 2;
        screenPosition -= ScreenCenter;
        float angle = Mathf.Atan2(screenPosition.y, screenPosition.x);
        angle -= 90 * Mathf.Deg2Rad;

        float cos = Mathf.Cos(angle);
        float sin = Mathf.Cos(angle);
        screenPosition = ScreenCenter += new Vector3(sin * 150, cos * 150, 0);
        float m = cos / sin;
        Vector3 screenBounds = ScreenCenter * 0.9f;

        if (cos > 0)
            {
            screenPosition = new Vector3(screenBounds.y / m, screenBounds.y, 0);
            } else {
            screenPosition = new Vector3(-screenBounds.y / m, -screenBounds.y, 0);
            }
        if (screenPosition.x > screenBounds.x)
            {
            screenPosition = new Vector3(screenBounds.x / m, screenBounds.x, 0);
            } else {
            screenPosition = new Vector3(-screenBounds.x, screenBounds.x * m, 0);
            }
        screenPosition += ScreenCenter;
        ApointingArrow.transform.localPosition = screenPosition;
    	}
}
