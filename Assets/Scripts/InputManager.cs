﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{
    // Start is called before the first frame update
    public static bool StartButton()
    {
        return Input.GetButton("Start_Button");
    }

    public static bool EndButton()
    {
        return Input.GetButton("End_Button");
    }



}
