using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Plast : MonoBehaviour
{
    public static Plast instance;
    PlayerControls controls;
    public GameObject plast;
    public Vector3 plast_position;
    public int counting = 0;

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
        controls.Game.Separuj_Plasty.performed += ctx => ShowPlast();

        controls.Game.Right.performed += ctx => Move_Right();

        controls.Game.Left.performed += ctx => Move_Left();

    }
    private void Start()
    {
        ShowPlast();
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.GetComponent<Renderer>().enabled = false;
    }


    public void Move_Right()
    {
        SetCurrentPosition(_currentPositionIndex + 1);
    }

    public void Move_Left()
    {
        SetCurrentPosition(_currentPositionIndex - 1);
    }

    public void ShowPlast()
    {
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.GetComponent<Renderer>().enabled = true;
        Papier.instance.gameObject.GetComponent<Renderer>().enabled = false;
        Sklo.instance.gameObject.GetComponent<Renderer>().enabled = false;

    }

    public void SetCurrentPosition(int positionIndex)
    {
        if (positionIndex < 0 || positionIndex >= _positions.Length)
            return;

        transform.position = _positions[positionIndex];
        _currentPositionIndex = positionIndex;
    }

    public void ReachPosition()
    {
        plast_position = Player.instance.GetActualPosition();
        plast.transform.position = plast_position;

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
