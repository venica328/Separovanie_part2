using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "phone" || other.gameObject.name == "computer")
        {
            Debug.Log("POHODA JAHODA");
        }
        else if(other.gameObject.name == "papier" || other.gameObject.name == "plast" || other.gameObject.name == "sklo")
        {
            Debug.Log("PAPIER/PLAST/SKLO ZLEEEEE");
            MenuManager.instance.IncreaseScore();
        }


    }
}
