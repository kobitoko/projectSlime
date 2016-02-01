using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FakeGameplayShit : MonoBehaviour {

    public Scene YouWinScene;
    public bool YouWinYouAreNotShitLIkeJeffGoKillYourselfYouFuckingLoser;
    public bool JeffisCryingLikeAlittleBitch;
    public float TimeTillJeffStartsCrying;
	// Use this for initialization
	void Start () {
        YouWinYouAreNotShitLIkeJeffGoKillYourselfYouFuckingLoser = false;
        JeffisCryingLikeAlittleBitch = false;
        TimeTillJeffStartsCrying = 3f;
	}
	
	// Update is called once per frame
	void Update () {
	
        if (YouWinYouAreNotShitLIkeJeffGoKillYourselfYouFuckingLoser == true)
            {
            PimpSlapJeffsMom();
            }
        TimeTillJeffStartsCrying -= Time.deltaTime;
        if (TimeTillJeffStartsCrying <= 0)
            {
            YouWinYouAreNotShitLIkeJeffGoKillYourselfYouFuckingLoser = true;
            }
	}
    public void PimpSlapJeffsMom()
        {
        SceneManager.LoadScene("YouWinScene");
        SceneManager.UnloadScene("EmptyGameplayTesting");
        SceneManager.SetActiveScene(YouWinScene);
        }
}
