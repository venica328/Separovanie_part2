using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeButton : MonoBehaviour
{
    public static HomeButton Instance;

    void Awake()
    {
        if (Instance == null) Instance = this;
    }

}