using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Glass : MonoBehaviour
{
    PlayerControls controls;
    [SerializeField]
    private int _currentPositionIndex;
    [SerializeField]
    private Vector3[] _positions = new Vector3[]
    {
        new Vector3(0,0,0)
    };
    private Vector3 player_position;
    private Vector2 target;

    public static Glass instance;
    public GameObject glass;
    public Vector3 glass_position;
    public int counter = 0;
    void Awake()
    {
        if (instance == null) instance = this;
        controls = new PlayerControls();
        controls.Game.Separuj_Sklo.performed += ctx => ShowGlass();
        controls.Game.Right.performed += ctx => Move_Right();
        controls.Game.Left.performed += ctx => Move_Left();
    }
    private void Start()
    {
        target = transform.position;
        if (MenuManager.instance.gameMenu)
        {
            ShowGlass();
        }
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.GetComponent<Renderer>().enabled = false;
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
        if (kb.aKey.wasPressedThisFrame)
        {
            ShowGlass();
        }

        Mouse mouse = InputSystem.GetDevice<Mouse>();
        if (mouse.leftButton.wasPressedThisFrame)
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
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
    public void ShowGlass()
    {
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.GetComponent<Renderer>().enabled = true;
        Paper.instance.gameObject.GetComponent<Renderer>().enabled = false;
        Plastic.instance.gameObject.GetComponent<Renderer>().enabled = false;
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
    }

    void OnDisable()
    {
        controls.Game.Disable();
    }
}
