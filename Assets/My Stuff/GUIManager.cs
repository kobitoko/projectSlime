using UnityEngine;  
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour {

    public enum Guistates
        {
        OpeningText1, OpeningText2, OpeningText3, OpeningText4, OpeningText5, OpeningText6, TitleScreen, CreditsScreen
        }
    public Guistates istate = new Guistates();
    public GameObject OpeningScreen1;
    public GameObject TitleScreen;
    public GameObject CreditsScreen;
    public GameObject YouWinScreen;
    public GameObject Text1Screen;
    public GameObject Text2Screen;
    public GameObject Text3Screen;
    public GameObject Text4Screen;
    public GameObject Text5Screen;
    public GameObject Text6Screen;
    public float FadeSpeed;
    public Text Part1Text;
    public Text Part2Text;
    public Text Part3Text;
    public Text Part4Text;
    public Text Part5Text;
    public Text Part6Text;
    public bool startTimer1;
    public bool startTimer2;
    public bool startTimer3;
    public bool startTimer4;
    public bool startTimer5;
    public bool startTimer6;
    public bool startTimer7;
    public bool startTimer15;
    public bool startTimer16;
    public float timer1;
    public float timer2; //not being used yet
    public float timer3;
    public float timer4;
    public float timer5;
    public float timer6;
    public float timer7;
    public float timer15;
    public float timer16;
    public Button StartButton;
    public Button CreditsButton;
    public bool canSkip;
    public float skipTimer;

	// Use this for initialization
	void Start () {

        startTimer15 = true;
        timer1 = 3f;
        timer2 = 3f;
        timer3 = 3f;
        timer4 = 2f;
        timer5 = 2f;
        timer6 = 2f;
        timer7 = 2f;
        timer15 = 3f;
        timer16 = 1f;
        OpeningScreen1.SetActive(false);
        OpeningScreen1.GetComponent<CanvasGroup>().alpha = 0;
        FadeSpeed = 0.3f;
        istate = Guistates.TitleScreen;
        TitleScreen.SetActive(true);
        TitleScreen.GetComponent<CanvasGroup>().alpha = 0;
        CreditsScreen.GetComponent<CanvasGroup>().alpha = 0;
        Part1Text.enabled = false;
        Part2Text.enabled = false;
        Part3Text.enabled = false;
        Part4Text.enabled = false;
        Part5Text.enabled = false;
        Part6Text.enabled = false;
        YouWinScreen.SetActive(false);
        canSkip = false;
        skipTimer = 1f;
        Text1Screen.SetActive(false);
        Text2Screen.SetActive(false);
        Text3Screen.SetActive(false);
        Text4Screen.SetActive(false);
        Text5Screen.SetActive(false);
        Text6Screen.SetActive(false);
	}
	
	// Update is called once per frame //15-16-1
	void Update () {
        
        if (startTimer1 == true) //3rd
            {
            timer1 -= Time.deltaTime;
                if (timer1 <= 0)
                    {
                    OpeningScreen1.GetComponent<CanvasGroup>().alpha += (Time.deltaTime * FadeSpeed);
                    if (OpeningScreen1.GetComponent<CanvasGroup>().alpha >= 1)
                        {
                        startTimer1 = false;
                        timer1 = 3f;
                        OpeningScreen1.GetComponent<CanvasGroup>().alpha = 1;
                        Part1Text.enabled = true;
                        Text1Screen.SetActive(true);
                        Text1Screen.GetComponent<Text>().enabled = true;
                       }
                   }
                }
        if (Text1Screen.activeSelf == true)
            {
            skipTimer -= Time.deltaTime;
            if (skipTimer <= 0)
                {
                canSkip = true;
                }
            if (canSkip == true && Input.GetKey(KeyCode.Space))
                {
                Text1Screen.SetActive(false);
                Text2Screen.SetActive(true);
                canSkip = false;
                skipTimer = 1f;
                Part2Text.GetComponent<Text>().enabled = true;
                }
            }
        if (Text2Screen.activeSelf == true)
            {
            skipTimer -= Time.deltaTime;
            if (skipTimer <= 0)
                {
                canSkip = true;
                }
            if (canSkip == true && Input.GetKey(KeyCode.Space))
                {
                Text2Screen.SetActive(false);
                Text3Screen.SetActive(true);
                canSkip = false;
                skipTimer = 1f;
                Part3Text.GetComponent<Text>().enabled = true;
                }
            }
        if (Text3Screen.activeSelf == true)
            {
            skipTimer -= Time.deltaTime;
            if (skipTimer <= 0)
                {
                canSkip = true;
                }
            if (canSkip == true && Input.GetKey(KeyCode.Space))
                {
                Text3Screen.SetActive(false);
                Text4Screen.SetActive(true);
                canSkip = false;
                skipTimer = 1f;
                Part4Text.GetComponent<Text>().enabled = true;
                }
            }
        if (Text4Screen.activeSelf == true)
            {
            skipTimer -= Time.deltaTime;
            if (skipTimer <= 0)
                {
                canSkip = true;
                }
            if (canSkip == true && Input.GetKey(KeyCode.Space))
                {
                Text4Screen.SetActive(false);
                Text5Screen.SetActive(true);
                canSkip = false;
                skipTimer = 1f;
                Part5Text.GetComponent<Text>().enabled = true;
                }
            }
        if (Text5Screen.activeSelf == true)
            {
            skipTimer -= Time.deltaTime;
            if (skipTimer <= 0)
                {
                canSkip = true;
                }
            if (canSkip == true && Input.GetKey(KeyCode.Space))
                {
                Text5Screen.SetActive(false);
                Text6Screen.SetActive(true);
                canSkip = false;
                skipTimer = 1f;
                Part6Text.GetComponent<Text>().enabled = true;
                }
            }
        if (Text6Screen.activeSelf == true)
            {
            skipTimer -= Time.deltaTime;
            if (skipTimer <= 0)
                {
                canSkip = true;
                }
            if (canSkip == true && Input.GetKey(KeyCode.Space))
                {
                Text2Screen.SetActive(false);;
                canSkip = false;
                skipTimer = 1f;
                StarttheGame();
                }
            }


        /*if (Part1Text.GetComponent<Text>().enabled == true)
            {
            canSkip = true;
            skipTimer -= Time.deltaTime;
            if (skipTimer <= 0)
                {
                canSkip = true;
                }
            if (canSkip == true && Input.GetKeyUp(KeyCode.Space))
                {
                Text1Screen.SetActive(false);
                Text2Screen.SetActive(true);
                canSkip = false;
                skipTimer = 1f;
                Part2Text.enabled = true;
                Debug.Log("a");
                return;
                }
            }
        if (Part2Text.GetComponent<Text>().enabled == true)
        //if (Text2Screen.activeSelf)
            {
            canSkip = true;
            skipTimer -= Time.deltaTime;
            if (skipTimer <= 0)
                {
                canSkip = true;
                }
            if (canSkip == true && Input.GetKeyUp(KeyCode.Space))
                {
                Text2Screen.SetActive(false);
                Text3Screen.SetActive(true);
                Part3Text.enabled = true;
                canSkip = false;
                skipTimer = 1f;
                Debug.Log("b");
                return;
                }
            }
        if (Part3Text.GetComponent<Text>().enabled == true)
            {
            canSkip = true;
            skipTimer -= Time.deltaTime;
            if (skipTimer <= 0)
                {
                canSkip = true;
                }
            if (canSkip == true && Input.GetKeyUp(KeyCode.Space))
                {
                Text3Screen.SetActive(false);
                Text4Screen.SetActive(true);
                Part4Text.enabled = true;
                canSkip = false;
                skipTimer = 1f;
                Debug.Log("c");
                return;
                }
            }
        if (Part4Text.GetComponent<Text>().enabled == true)
            {
            canSkip = true;
            skipTimer -= Time.deltaTime;
            if (skipTimer <= 0)
                {
                canSkip = true;
                }
            if (canSkip == true && Input.GetKeyUp(KeyCode.Space))
                {
                Text4Screen.SetActive(false);
                Text5Screen.SetActive(true);
                Part5Text.enabled = true;
                canSkip = false;
                skipTimer = 1f;
                Debug.Log("d");
                return;
                }
            }
        if (Part5Text.GetComponent<Text>().enabled == true)
            {
            canSkip = true;
            skipTimer -= Time.deltaTime;
            if (skipTimer <= 0)
                {
                canSkip = true;
                }
            if (canSkip == true && Input.GetKeyUp(KeyCode.Space))
                {
                Text5Screen.SetActive(false);
                Text6Screen.SetActive(true);
                Part5Text.enabled = true;
                canSkip = false;
                skipTimer = 1f;
                Debug.Log("e");
                return;
                }
            }
        if (Part6Text.GetComponent<Text>().enabled == true)
            {
            canSkip = true;
            skipTimer -= Time.deltaTime;
            if (skipTimer <= 0)
                {
                canSkip = true;
                }
            if (canSkip == true && Input.GetKeyUp(KeyCode.Space))
                {
                Part6Text.GetComponent<Text>().enabled = false;
                Part6Text.enabled = true;
                canSkip = false;
                skipTimer = 1f;
                return;
                }
            }*/


        if (startTimer15 == true) //1st
            {
            timer15 -= Time.deltaTime;
                if (timer15 <= 0)
                    {
                    TitleScreen.GetComponent<CanvasGroup>().alpha += (Time.deltaTime * FadeSpeed);
                    if (TitleScreen.GetComponent<CanvasGroup>().alpha >= 1)
                        {
                        startTimer15 = false;
                        timer15 = 3f;
                        TitleScreen.GetComponent<CanvasGroup>().alpha = 1;
                        StartButton.interactable = true;
                        CreditsButton.interactable = true;
                        }
                    }
            }
        if (startTimer16 == true) //2nd
            {
            timer16 -= Time.deltaTime;
            if (timer16 <= 0)
                {
                TitleScreen.GetComponent<CanvasGroup>().alpha -= (Time.deltaTime * FadeSpeed);
                if (TitleScreen.GetComponent<CanvasGroup>().alpha <= 0)
                    {
                    startTimer16 = false;
                    timer16 = 3f;
                    TitleScreen.GetComponent<CanvasGroup>().alpha = 0;
                    startTimer1 = true;
                    OpeningScreen1.SetActive(true);
                    }
                }
            }
                if (startTimer4 == true)
                {
                timer4 -= Time.deltaTime;
                if (timer4 <= 0)
                    {
                    TitleScreen.GetComponent<CanvasGroup>().alpha -= (Time.deltaTime * FadeSpeed);
                        if (TitleScreen.GetComponent<CanvasGroup>().alpha <= 0)
                        {
                        startTimer4 = false;
                        timer4 = 2f;
                        TitleScreen.GetComponent<CanvasGroup>().alpha = 0;
                        startTimer5 = true;
                        }
                    }
                }
                if (startTimer5 == true)
                {
                timer5 -= Time.deltaTime;
                if (timer5 <= 0)
                    {
                    CreditsScreen.GetComponent<CanvasGroup>().alpha += (Time.deltaTime * FadeSpeed);
                    if (CreditsScreen.GetComponent<CanvasGroup>().alpha >= 1)
                        {
                        startTimer5 = false;
                        timer5 = 2f;
                        CreditsScreen.GetComponent<CanvasGroup>().alpha = 1;
                        }
                    }
                }
                if (startTimer6 == true)
                {
                timer6 -= Time.deltaTime;
                if (timer6 <= 0)
                    {
                    CreditsScreen.GetComponent<CanvasGroup>().alpha -= (Time.deltaTime * FadeSpeed);
                    if (CreditsScreen.GetComponent<CanvasGroup>().alpha <= 0)
                        {
                        startTimer6 = false;
                        timer6 = 2f;
                        CreditsScreen.GetComponent<CanvasGroup>().alpha = 0;
                        startTimer7 = true;
                        }
                    }
                }
                if (startTimer7 == true)
                {
                timer7 -= Time.deltaTime;
                if (timer7 <= 0)
                    {
                    TitleScreen.GetComponent<CanvasGroup>().alpha += (Time.deltaTime * FadeSpeed);
                        {
                        if (TitleScreen.GetComponent<CanvasGroup>().alpha >= 1)
                            {
                            startTimer7 = false;
                            timer7 = 2f;
                            TitleScreen.GetComponent<CanvasGroup>().alpha = 1;
                            }
                        }
                    }
                }
            
        /*if (startTimer2 == true) //16th
            {
            timer2 -= Time.deltaTime;
            if (timer2 <= 0)
                {
                OpeningScreen1.GetComponent<CanvasGroup>().alpha -= (Time.deltaTime * FadeSpeed);
                if (OpeningScreen1.GetComponent<CanvasGroup>().alpha <= 0)
                    {
                    startTimer2 = false;
                    timer2 = 3f;
                    OpeningScreen1.GetComponent<CanvasGroup>().alpha = 0;
                    }
                }
            }*/
	    }
    public void StartingGame()
        {
        startTimer16 = true;
        }
    public void OpenCredits()
        {
        startTimer4 = true;
        CreditsScreen.SetActive(true);
        }
    public void StarttheGame()
        {
        OpeningScreen1.SetActive(false);
        TitleScreen.SetActive(false);
        CreditsScreen.SetActive(false);
        SceneManager.LoadScene("Assets/Scenes/TestingLevel.unity");
        }
    public void YouWin()
        {
        //Pause Game Shit goes here
        YouWinScreen.SetActive(true);
        //whatever else needs to go off here!
        }
    public void ReturntoStartMenu()
        {
        YouWinScreen.SetActive(false);;
        startTimer6 = true;
        TitleScreen.SetActive(true);
        CreditsScreen.SetActive(false);
        }
    }