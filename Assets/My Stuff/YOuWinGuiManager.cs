using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class YOuWinGuiManager : MonoBehaviour {
    public Scene BensScene;
    public GameObject YouWinScreen;
	// Use this for initialization
	void Start () {
        YouWinScreen.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void EnterYouWinScreen()
        {;
        SceneManager.LoadScene("BensScene");
        SceneManager.UnloadScene("EmptyGameplayTesting");
        //cSceneManager.SetActiveScene(BensScene);
        }
}
