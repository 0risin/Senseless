using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityStandardAssets.CrossPlatformInput;

class DesktopInput : IInputProvider
{
    public float XAxis
    {
        get
        {
            return CrossPlatformInputManager.GetAxis("Mouse Y");
        }
    }

    public float YAxis
    {
        get
        {
            return CrossPlatformInputManager.GetAxis("Mouse X");
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
            return CrossPlatformInputManager.GetButtonDown("Jump");
        }
    }

    public bool Use
    {
        get
        {
            return CrossPlatformInputManager.GetButtonDown("Use");
        }
    }

    public bool Back
    {
        get
        {
            return CrossPlatformInputManager.GetButtonDown("Back");
        }
    }
}