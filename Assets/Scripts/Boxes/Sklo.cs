using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Sklo : MonoBehaviour
{
    public static Sklo instance;

    PlayerControls controls;
    public GameObject sklo;
    public Vector3 sklo_position;
    public int counter = 0;


    [SerializeField]
    private int _currentPositionIndex;

    private Vector3 player_position;

    [SerializeField]
    private Vector3[] _positions = new Vector3[]
    {
        new Vector3(0,0,0)

    };

    void Awake()
    {
        if (instance == null) instance = this;
        controls = new PlayerControls();
        controls.Game.Separuj_Sklo.performed += ctx => ShowSklo();
        controls.Game.Right.performed += ctx => Move_Right();

        controls.Game.Left.performed += ctx => Move_Left();

    }
    private void Start()
    {
        if (MenuManager.instance.gameMenu)
        {
            ShowSklo();
        }
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.GetComponent<Renderer>().enabled = false;
        SetCurrentPosition(_currentPositionIndex + 0);
    }


    public void Move_Right()
    {
        SetCurrentPosition(_currentPositionIndex + 1);
    }

    public void Move_Left()
    {
        SetCurrentPosition(_currentPositionIndex - 1);
    }


    public void ShowSklo()
    {
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.GetComponent<Renderer>().enabled = true;
        Papier.instance.gameObject.GetComponent<Renderer>().enabled = false;
        Plast.instance.gameObject.GetComponent<Renderer>().enabled = false;

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
