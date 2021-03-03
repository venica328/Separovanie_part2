using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Paper : MonoBehaviour
{
    public static Paper instance;

    PlayerControls controls;
    public GameObject paper;
    public Vector3 paper_position;
    public int count = 0;
    [SerializeField]
    private int _currentPositionIndex;

    private Vector3 player_position;

    [SerializeField]
    private Vector3[] _positions = new Vector3[]
    {
        new Vector3(0,0,0)
    };
    private Vector2 target;
    
    void Awake()
    {
        if (instance == null) instance = this;

        controls = new PlayerControls();
        controls.Game.Separuj_Papier.canceled += ctx => ShowPaper();
        controls.Game.Right.performed += ctx => Move_Right();
        controls.Game.Left.performed += ctx => Move_Left();
    }
    private void Start()
    {
        target = transform.position;
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.GetComponent<Renderer>().enabled = false;
        ShowPaper();
        SetCurrentPosition(_currentPositionIndex + 0);
    }

    private void Update()
    {
        Keyboard kb = InputSystem.GetDevice<Keyboard>();
        if (kb.rightArrowKey.wasPressedThisFrame)
        {
            Move_Right();
        }
        if (kb.leftArrowKey.wasPressedThisFrame)
        {
            Move_Left();
        }
        if (kb.sKey.wasPressedThisFrame)
        {
            ShowPaper();
        }

        Mouse mouse = InputSystem.GetDevice<Mouse>();
        if (mouse.leftButton.wasPressedThisFrame)
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // target.y = transform.position.y;
            if (target.x >= -2 || target.x <= 2 && _currentPositionIndex != 1 && _currentPositionIndex == 0)
            {
                Move_Right();
            }
            if (target.x >= -2 || target.x <= 2 && _currentPositionIndex != 0 && _currentPositionIndex == 2)
            {
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
    }

    public void Move_Left()
    {
        SetCurrentPosition(_currentPositionIndex - 1);
    }

    public void ShowPaper()
    {
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.GetComponent<Renderer>().enabled = true;
        Plastic.instance.gameObject.GetComponent<Renderer>().enabled = false;
        Glass.instance.gameObject.GetComponent<Renderer>().enabled = false;
    }

    public void SetCurrentPosition(int positionIndex)
    {
        if (positionIndex < 0 || positionIndex >= _positions.Length)
            return;
        transform.position = _positions[positionIndex];
        _currentPositionIndex = positionIndex;
    }


    void OnEnable()
    {
        controls.Game.Enable();
        controls.Game.Separuj_Papier.Enable();
    }

    void OnDisable()
    {
        controls.Game.Disable();
    }

  

}
