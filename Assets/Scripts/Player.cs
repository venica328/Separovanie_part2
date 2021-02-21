using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    PlayerControls controls;

    public static Player instance;

    [SerializeField]
    private float moveSpeed;

    private bool startMoving = false;

    public bool StartMoving { get { return startMoving; } set { startMoving = value; } }

    private void Awake()
    {
        if (instance == null) instance = this;

        controls = new PlayerControls();
        controls.Game.R_Move.performed += ctx => moveRight();
    }


    

    // Update is called once per frame
    void Update()
    {
        /**
        if (Input.GetMouseButtonDown(0))
        {
            movingRight = !movingRight;
            direction = -direction;
            transform.localScale = new Vector3(direction, 1, 1);

        if (startMoving == false) return;

        ChangeDirection();

        transform.position += Vector3.right * moveSpeed * Time.deltaTime * direction;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -xLimit, xLimit), transform.position.y, transform.position.z);
        }**/

        transform.Translate(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0, 0);
        Vector3 characterScale = transform.localScale;
        if(Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = -1;
        }
        if(Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = 1;
        }
        transform.localScale = characterScale;

        /**
        void ChangeDirection()
        {
            if (movingRight && transform.position.x >= xLimit)
            {
                movingRight = false;
                direction = -1;
                transform.localScale = new Vector3(direction, 1, 1);
            }

            if (!movingRight && transform.position.x <= -xLimit)
            {
                movingRight = true;
                direction = 1;
                transform.localScale = new Vector3(direction, 1, 1);
            }
        }
        **/
    }

    private void moveRight()
    {
        transform.position *= new Vector2(5, -2);
    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        /**if (other.CompareTag("Falling"))
        {
            MenuManager.instance.GameOver();
            gameObject.SetActive(false);
        }**/
        if(other.gameObject.name == "computer" || other.gameObject.name == "phone")
        {
            Debug.Log("quit");
            gameObject.SetActive(false);
            MenuManager.instance.GameOver();
            gameObject.SetActive(false);
        }
    }

}
