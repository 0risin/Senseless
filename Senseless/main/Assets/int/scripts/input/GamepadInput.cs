using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

class GamepadInput : IInputProvider
{
    public float XAxis
    {
        get
        {
            return CrossPlatformInputManager.GetAxis("Joy Y") * -15;
        }
    }

    public float YAxis
    {
        get
        {
            return CrossPlatformInputManager.GetAxis("Joy X") * 15;
        }
    }

    public float Horizontal
    {
        get
        {
            return CrossPlatformInputManager.GetAxis("Horizontal");
        }
    }

    public float Vertical
    {
        get
        {
            return CrossPlatformInputManager.GetAxis("Vertical");
        }
    }

    public bool Jump
    {
        get
        {
            return CrossPlatformInputManager.GetButtonUp("Jump");
        }
    }

    public bool Use
    {
        get
        {
            return CrossPlatformInputManager.GetButtonUp("Submit");
        }
    }

    public bool Back
    {
        get
        {
            return CrossPlatformInputManager.GetButtonUp("Back");
        }
    }
}