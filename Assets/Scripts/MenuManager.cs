using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class MenuManager : MonoBehaviour
{
    public static MenuManager instance;
    PlayerControls controls;

    [SerializeField]
    private Text scoreText, separatingText, finalScore, finalSeparatedScore, countDown;
    [SerializeField]
    public GameObject gameMenu, gameOverMenu, menu, playButton;

    private int currentSeparating, currentScore;
    public int timeLeft = 10;
    public int counter = 0;

    void Awake()
    {
        if (instance == null)
            instance = this;
        controls = new PlayerControls();
        controls.Game.Separuj_Papier.performed += ctx => PlayButton();
        controls.Game.Separuj_Papier.canceled += ctx => Paper.instance.ShowPaper();
    }

    void Start()
    {
        scoreText.text = "" + 0;
        separatingText.text = "" + 0;
        controls.Game.End_Game.performed += ctx => QuitApplication();
    }

    void Update()
    {
        Keyboard kb = InputSystem.GetDevice<Keyboard>();
        if (kb.enterKey.wasPressedThisFrame)
        {
            Debug.Log("start cez enter");
            PlayButton();
        }
        if (kb.escapeKey.wasPressedThisFrame)
        {
            Debug.Log("koniec cez escape");
            QuitApplication();
        }

        countDown.text = ("" + timeLeft);
        if (timeLeft == 0)
        {
            MenuManager.instance.GameOver();
            controls.Game.Separuj_Papier.performed += ctx => QuitApplication();
            controls.Game.End_Game.performed += ctx => HomeButton();
            if (kb.escapeKey.wasPressedThisFrame)
            {
                Debug.Log("koniec cez escape");
                QuitApplication();
            }
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

    public void IncreaseSeparating()
    {
        currentSeparating++;
        separatingText.text = "" + currentSeparating;
    }


    public void IncreaseScore()
    {
        currentScore++;
        scoreText.text = "" + currentScore;
    }

    
    public void PlayButton()
    {
        StartCoroutine("LoseTime");
        Time.timeScale = 1;
        Debug.Log("PLAY BUTTON");
        menu.SetActive(false);
        gameMenu.SetActive(true);
        Player.Instance.StartMoving = true;
        FallingObjects.instance.gameObject.SetActive(true);
        controls.Game.End_Game.Disable();
    }

    public void GameOver()
    {
       FallingObjects.instance.gameObject.SetActive(false);
       Player.Instance.StartMoving = false;
       gameMenu.SetActive(false);
       menu.SetActive(false);
       gameOverMenu.SetActive(true);
       finalScore.text = "Spadnuté: " + currentScore;
       finalSeparatedScore.text = "Vyzbierané: " + currentSeparating;        
    }

    public void HomeButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        FallingObjects.instance.gameObject.SetActive(false);
        Player.Instance.StartMoving = (false);
        gameMenu.SetActive(false);
        menu.SetActive(true);
        gameOverMenu.SetActive(false);
    }

    public void QuitApplication()
    {
        Debug.Log("JE KONIEC");
        Application.Quit();
    }

    void OnEnable()
    {
        controls.Game.Enable();
    }

    void OnDisable()
    {
        controls.Game.Disable();
    }
}
