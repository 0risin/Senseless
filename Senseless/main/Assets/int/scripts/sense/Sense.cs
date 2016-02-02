using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Sense {

    public enum Type { Hear, Gravity, Look, Feel, Strength, Dexterity, Orientation};

    private bool isactive = false;
    public bool Active
    {
        get
        {
            return isactive;
        }
    }

    public virtual bool DefaultEnabled
    {
        get
        {
            return true;
        }
    }

    public virtual void On(Trigger trigger)
    {
        isactive = true;
    }

    public virtual void Off(Trigger trigger)
    {
        isactive = false;
    }


    protected void enable(string name)
    {
        GameObject obj = Root.Instance.SenseManager.GetLayerItem(name);

        if (obj != null)
        {
            obj.SetActive(true);
        }
        else
        {
            Debug.Log(name + " not found");
        }
    }

    public virtual void Update()
    {
    }

    protected void disable(string name)
    {
        GameObject obj = Root.Instance.SenseManager.GetLayerItem(name);

        if (obj != null)
        {
            obj.SetActive(false);
        }
        else
        {
            Debug.Log(name + " not found");
        }
    }
}
