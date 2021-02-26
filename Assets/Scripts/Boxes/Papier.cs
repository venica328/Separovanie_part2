using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Papier : MonoBehaviour
{
    public static Papier instance;

    PlayerControls controls;
    public GameObject papier;
    public Vector3 papier_position;
    public int count = 0;
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
        controls.Game.Separuj_Papier.canceled += ctx => ShowPapier();
        controls.Game.Right.performed += ctx => Move_Right();

        controls.Game.Left.performed += ctx => Move_Left();

    }
    private void Start()
    {
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.GetComponent<Renderer>().enabled = false;
        ShowPapier();
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


    public void ShowPapier()
    {
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.GetComponent<Renderer>().enabled = true;
        Plast.instance.gameObject.GetComponent<Renderer>().enabled = false;
        Sklo.instance.gameObject.GetComponent<Renderer>().enabled = false;
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
