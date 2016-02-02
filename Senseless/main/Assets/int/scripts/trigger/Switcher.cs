using UnityEngine;
using System.Collections;

public class Switcher : Trigger {

    public Sense.Type Enable;
    public Sense.Type Disable;

    protected override void OnEnter()
    {
        SwitchOn(Enable);
        SwithchOff(Disable);
    }
}
