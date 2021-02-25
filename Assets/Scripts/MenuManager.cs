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
    private GameObject gameMenu, gameOverMenu, menu;

    private int currentSeparating, currentScore;
    private int timeLeft = 10;
    public int counter;




    void Awake()
    {
        if (instance == null)
            instance = this;
        controls = new PlayerControls();

        controls.Game.Separuj_Papier.performed += ctx => PlayButton();
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "" + 0;
        separatingText.text = "" + 0;
        if (gameMenu)
        {
            StartCoroutine("LoseTime");
            Time.timeScale = 1;
        }

        //PlayButton();


    }

    void Update()
    {
        countDown.text = ("" + timeLeft);
        if (timeLeft == 0)
        {
            Application.Quit();
            MenuManager.instance.GameOver();
            
                if (InputManager.EndButton())
                {
                    Debug.Log("Ide to Vejka");
                    HomeButton();
                }

        }
            //PlayButton();

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
        currentScore++;
        scoreText.text = "" + currentScore;
    }


    public void PlayButton()
    {
            counter++;
            Debug.Log("PODARILO SA");
            menu.SetActive(false);
            gameMenu.SetActive(true);
            Player.instance.StartMoving = true;
        
    }

    public void GameOver()
    {
       FallingObjects.instance.gameObject.SetActive(false);
       Player.instance.StartMoving=(false);
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
        Player.instance.StartMoving = (false);
        gameMenu.SetActive(false);
        menu.SetActive(true);
        gameOverMenu.SetActive(false);

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
