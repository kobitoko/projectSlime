using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class YOuWinGuiManager : MonoBehaviour {

    public GameObject YouWinScreen;
	// Use this for initialization
	void Start () {
        YouWinScreen.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void EnterYouWinScreen()
        {
        YouWinScreen.SetActive(true);
        SceneManager.LoadScene("Assets/Scene/Bens Scene.unity");
        }
}
