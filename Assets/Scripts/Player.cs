using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    
    PlayerControls controls;
    Vector2 move;
    Vector3 middle = new Vector3(0f, -2.0f, 0.0f);
    Vector3 right = new Vector3(5f, -2.0f, 0.0f);
    Vector3 left = new Vector3(-5f, -2.0f, 0.0f);
    Vector3 step = new Vector3(5f, 0.0f, 0.0f);
    Vector3 start = new Vector3(0f, -2.0f, 0.0f);
    Vector3 pom = Vector3.zero;


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

      //  controls.Game.Right.performed += ctx => right = ctx.ReadValue<Vector2>();
        controls.Game.Right.performed += ctx => Move_Right();
        controls.Game.Right.canceled += ctx => move = Vector2.zero;

        controls.Game.Left.performed += ctx => Move_Left();
        controls.Game.Left.canceled += ctx => move = Vector2.zero;

        
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

    public Vector3 Move_Right()
    {
        //transform.position = right;
        //transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        transform.position = start + step;
        transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        pom = transform.position;

        return pom;
    }

    public Vector3 Move_Left()
    {
       
        transform.position = pom - step;
        transform.position += Vector3.right * moveSpeed * Time.deltaTime;

        start = transform.position;
        return start;
    }

    void OnEnable()
    {
        controls.Game.Enable();
    }

    void OnDisable()
    {
        controls.Game.Disable();
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "computer" || other.gameObject.name == "phone")
        {
            Debug.Log("quit");
            gameObject.SetActive(false);
            MenuManager.instance.GameOver();
            gameObject.SetActive(true);
        }
    }

}
