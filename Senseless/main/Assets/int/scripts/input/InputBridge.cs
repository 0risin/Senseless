using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class InputBridge: IInputProvider
{
    private IInputProvider provider = new GamepadInput();

    public InputBridge()
    {
        if (Input.GetJoystickNames().Length <= 0)
        {
            provider = new DesktopInput();
        }
        else
        {
            provider = new GamepadInput();
        }
    }

    public float XAxis
    {
        get
        {
            return provider.XAxis;
        }
    }

    public float YAxis
    {
        get
        {
            return provider.YAxis;
        }
    }

    public float Horizontal
    {
        get
        {
            return provider.Horizontal;
        }
    }

    public float Vertical
    {
        get
        {
            return provider.Vertical;
        }
    }

    public bool Jump
    {
        get
        {
            return provider.Jump;
        }
    }

    public bool Use
    {
        get
        {
            return provider.Use;
        }
    }

    public bool Back
    {
        get
        {
            return provider.Back;
        }
    }
}