using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour
{
    public GameObject Item;

    public virtual void SwitchOn(Sense.Type type)
    {
        Sense sense = Root.Instance.SenseManager.GetSense(type);

        if (sense != null)
        {
            sense.On(this);
        }
    }

    public virtual void SwithchOff(Sense.Type type)
    {
        Sense sense = Root.Instance.SenseManager.GetSense(type);

        if (sense != null)
        {
            sense.Off(this);
        }
    }

    public void Toggle(Sense.Type type)
    {
        Sense sense = Root.Instance.SenseManager.GetSense(type);
        if (sense == null)
        {
            return;
        }

        if (sense.Active)
        {
            sense.On(this);
        }
        else
        {
            sense.Off(this);
        }
    }

    void OnTriggerEnter()
    {
        OnEnter();
    }

    void OnTriggerLeave()
    {
        OnLeave();
    }

    protected virtual void OnEnter() { }
    protected virtual void OnLeave() { }
}