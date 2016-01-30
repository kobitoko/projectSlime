using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour {

    public enum Guistates
        {
        OpeningText1, OpeningText2, OpeningText3, OpeningText4, OpeningText5, OpeningText6, TitleScreen, CreditsScreen
        }
    public Guistates istate = new Guistates();
    public GameObject OpeningScreen1;
    public GameObject TitleScreen;
    public GameObject CreditsScreen;
    
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
    public bool startTimer15;
    public bool startTimer16;
    public float timer1;
    public float timer2; //not being used yet
    public float timer3;
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
        timer15 = 3f;
        timer16 = 1f;
        OpeningScreen1.SetActive(false);
        OpeningScreen1.GetComponent<CanvasGroup>().alpha = 0;
        FadeSpeed = 0.3f;
        istate = Guistates.TitleScreen;
        TitleScreen.SetActive(true);
        TitleScreen.GetComponent<CanvasGroup>().alpha = 0;
        Part1Text.enabled = false;
        Part2Text.enabled = false;
        Part3Text.enabled = false;
        Part4Text.enabled = false;
        Part5Text.enabled = false;
        Part6Text.enabled = false;
        canSkip = false;
        skipTimer = 1f;
	}
	
	// Update is called once per frame
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
                        }
                    }
            }
        if (Part1Text.GetComponent<Text>().enabled == true)
            {
            canSkip = true;
            skipTimer -= Time.deltaTime;
            if (skipTimer <= 0)
                {
                canSkip = true;
                }
            if (canSkip == true && Input.GetKeyUp(KeyCode.Space))
                {
                Part1Text.GetComponent<Text>().enabled = false;
                Part2Text.GetComponent<Text>().enabled = true;
                canSkip = false;
                skipTimer = 1f;
                Debug.Log("a");
                return;
                }
            }
        if (Part2Text.GetComponent<Text>().enabled == true)
            {
            canSkip = true;
            skipTimer -= Time.deltaTime;
            if (skipTimer <= 0)
                {
                canSkip = true;
                }
            if (canSkip == true && Input.GetKeyUp(KeyCode.Space))
                {
                Part2Text.GetComponent<Text>().enabled = false;
                Part3Text.GetComponent<Text>().enabled = true;
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
                Part3Text.GetComponent<Text>().enabled = false;
                Part4Text.GetComponent<Text>().enabled = true;
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
                Part4Text.GetComponent<Text>().enabled = false;
                Part5Text.GetComponent<Text>().enabled = true;
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
                Part5Text.GetComponent<Text>().enabled = false;
                Part6Text.GetComponent<Text>().enabled = true;
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
                canSkip = false;
                skipTimer = 1f;
                return;
                }
            }


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
        TitleScreen.SetActive(false);
        CreditsScreen.SetActive(false);
        }
    public void StarttheGame()
        {
        OpeningScreen1.SetActive(false);
        }
    }