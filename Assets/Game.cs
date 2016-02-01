using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {

	// Use this for initialization
	void Start () {

	SceneManager.LoadScene("YouWinScene");
	SceneManager.LoadScene("Main Scene");

	SceneManager.LoadScene("BensScene");

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
