using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    PlayerControls controls;
    Vector3 move;
    public static Player instance;

    [SerializeField]
    private float moveSpeed;

    private bool startMoving = false;

    public bool StartMoving { get { return startMoving; } set { startMoving = value; } }

    private void Awake()
    {
        if (instance == null) instance = this;

    }


    private void Update()


    {

        Gamepad gamepad = Gamepad.current;
        // The return value of `.current` cann be null.
        if (gamepad == null)
        {
            return;
        }


        if (InputManager.EndButton())
        {
            Debug.Log("HomeButton");
            MenuManager.instance.GameOver();
            gameObject.SetActive(false);

            MenuManager.instance.HomeButton();
            gameObject.SetActive(true);
        }

        //float amtToMove = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        //transform.Translate(Vector3.right * amtToMove);
        float amtToMove = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(new Vector2(10f,0f) * amtToMove);

        




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
