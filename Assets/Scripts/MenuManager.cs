using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class MenuManager : MonoBehaviour
{

    PlayerControls start;

    public static MenuManager instance;

    private int selectedButtons = 1;
    [SerializeField]
    private int NumberOfButtons;

    public Transform Button1;
    public Transform Buttons2;
    public Transform Button3;

    [SerializeField]
    private Text scoreText, separatingText, finalScore, finalSeparatedScore, countDown;
    [SerializeField]
    private GameObject gameMenu, gameOverMenu, menu;

    private int currentSeparating, currentScore;
    private int timeLeft = 60;




    void Awake()
    {
        if (instance == null)
            instance = this;

        start = new PlayerControls();
        start.Game.Start_Game.performed += ctx => PlayButton();

        onPlay();
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "" + 0;
        separatingText.text = "" + 0;

        StartCoroutine("LoseTime");
        Time.timeScale = 1;
    }

    void Update()
    {
        countDown.text = ("" + timeLeft);
        if(timeLeft == 0)
        {
            Application.Quit();
            MenuManager.instance.GameOver();
            gameObject.SetActive(false);

        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }


    // Update is called once per frame
    public void IncreaseSeparating()
    {
        currentSeparating++;
        separatingText.text = "" + currentSeparating;
    }


    public void IncreaseScore()
    {
        currentScore++ ;
        scoreText.text = "" + currentScore;
    }


    public void PlayButton()
    {
        menu.SetActive(false);
        gameMenu.SetActive(true);
        Player.instance.StartMoving = true;
    }

    public void onPlay()
    {
        if(selectedButtons == 1)
        {
            PlayButton();
        }
        else if(selectedButtons == 2)
        {
            HomeButton();
        }
    }


    public void GameOver()
    {
            FallingObjects.instance.gameObject.SetActive(false);
            gameMenu.SetActive(false);
            menu.SetActive(false);
            gameOverMenu.SetActive(true);
            finalScore.text = "Spadnuté: " + currentScore;
            finalSeparatedScore.text = "Vyzbierané: " + currentSeparating;
           
        
    }

    public void HomeButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
