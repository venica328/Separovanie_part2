﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coliders : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {       
        if(other.CompareTag("Player"))
        {
            Debug.Log("Collided with player");
            gameObject.SetActive(false);
        }

    }

    
}
