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
    public static Player instance;

    [SerializeField]
    private float moveSpeed;

    private bool startMoving = false;

    public bool StartMoving { get { return startMoving; } set { startMoving = value; } }

    void Awake()
    {
        if (instance == null) instance = this;

        controls = new PlayerControls();

        controls.Game.Right.performed += ctx => Move_Right();

        controls.Game.Left.performed += ctx => Move_Left();
    }

    void Update()
    {
            if (InputManager.EndButton())
            {
                Debug.Log("HomeButton");
                MenuManager.instance.GameOver();
                gameObject.SetActive(false);

                MenuManager.instance.HomeButton();
                gameObject.SetActive(true);
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
        if (other.gameObject.name == "computer" || other.gameObject.name == "phone")
        {
            Debug.Log("quit");
            gameObject.SetActive(false);
            MenuManager.instance.GameOver();
            gameObject.SetActive(true);
        }
    }
}
