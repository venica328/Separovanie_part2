using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{
    PlayerControls controls;
    [SerializeField] 
    private int _currentPositionIndex;
    private Vector3 player_position;
    [SerializeField]
    private Vector3[] _positions = new Vector3[]
    {
        new Vector3(0,0,0)
    };
    private GameObject player;
    public static Player Instance;
    [SerializeField]
    private float moveSpeed;
    private bool startMoving = false;
    public bool StartMoving { get { return startMoving; } set { startMoving = value; } }

    private Vector2 target;
    private void Start()
    {
        target = transform.position;
    }

    void Awake()
    {
        if (Instance == null) Instance = this;
        controls = new PlayerControls();
        controls.Game.Right.performed += ctx => Move_Right();
        controls.Game.Left.performed += ctx => Move_Left();
    }

    void Update()
    {
        Keyboard kb = InputSystem.GetDevice<Keyboard>();
        if(MenuManager.instance.timeLeft == 0)
        {
            controls.Game.End_Game.performed += ctx => MenuManager.instance.HomeButton();

            if (kb.enterKey.wasPressedThisFrame)
            {
                Debug.Log("home cez enter");
                MenuManager.instance.HomeButton();
            }
        }
        if (kb.leftArrowKey.wasPressedThisFrame)
        {
            Debug.Log("left move");
            Move_Left();
        }
        if (kb.rightArrowKey.wasPressedThisFrame)
        {
            Debug.Log("right move");
            Move_Right();
        }

        Mouse mouse = InputSystem.GetDevice<Mouse>();
        if (mouse.leftButton.wasPressedThisFrame)
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(target.x >= -2 || target.x <= 2 && _currentPositionIndex != 1 && _currentPositionIndex == 0)
            {
                Debug.Log("JE VACSI AKO TARGET.X");
                Move_Right();
            }
            if (target.x >= -2 || target.x <= 2 && _currentPositionIndex != 0 && _currentPositionIndex == 2)
            {
                Debug.Log("JE VACSI AKO TARGET.X");
                Move_Left();
            }
            if (target.x < -2 && _currentPositionIndex != 0)
            {
                Move_Left();
            }
            if (target.x > -2 && _currentPositionIndex != 1)
            {
                Move_Right();
            }
            if (target.x > 2 && _currentPositionIndex != 2)
            {
                Move_Right();
            }
        }
    }

    public void Move_Right()
    {
        SetCurrentPosition(_currentPositionIndex + 1);
        Debug.Log("volanie");
        GetActualPosition();
    }

    public void Move_Left()
    {
        SetCurrentPosition(_currentPositionIndex - 1);
        Debug.Log("volanie2");
        GetActualPosition();
    }

    void OnEnable()
    {
        controls.Game.Enable();
    }

    void OnDisable()
    {
        controls.Game.Disable();
    }

    public void SetCurrentPosition(int positionIndex)
    {
        if (positionIndex < 0 || positionIndex >= _positions.Length)
            return;

        transform.position = _positions[positionIndex];
        _currentPositionIndex = positionIndex;
    }

    public Vector3 GetActualPosition()
    {
        player_position = transform.position;
        Debug.Log(player_position);
        return player_position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!MenuManager.instance.gameOverMenu)
            return;
        if (Glass.instance.gameObject.GetComponent<Renderer>().enabled)
        {
            if (other.gameObject.name != "sklo")
            {
                Debug.Log("SOM DEBIL NECHYTIL SOM SKLO");
                MenuManager.instance.IncreaseScore();
            } else
            {
                MenuManager.instance.IncreaseSeparating();
            }
        }
        else if (Paper.instance.gameObject.GetComponent<Renderer>().enabled)
        {
            if (other.gameObject.name != "papier")
            {
                Debug.Log("SOM DEBIL NECHYTIL SOM PAPIER");
                MenuManager.instance.IncreaseScore();
            } else
            {
                MenuManager.instance.IncreaseSeparating();
            }
        }
        else if (Plastic.instance.gameObject.GetComponent<Renderer>().enabled)
        {
            if (other.gameObject.name != "plast")
            {
                Debug.Log("SOM DEBIL NECHYTIL SOM PLAST");
                MenuManager.instance.IncreaseScore();
            } else
            {
                MenuManager.instance.IncreaseSeparating();
            }
        }

        if (other.gameObject.name == "computer" || other.gameObject.name == "phone")
        {
            Debug.Log("ELEKTRONIKA SA NESEPARUJE");
        }
    }
}
