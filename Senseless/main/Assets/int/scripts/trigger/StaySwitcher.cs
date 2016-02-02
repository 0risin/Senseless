using UnityEngine;
using System.Collections;

public class StaySwitcher : Trigger {

    public Sense.Type Enable;
    public Sense.Type Disable;

    protected override void OnEnter()
    {
        SwitchOn(Enable);
        SwithchOff(Disable);
    }

    protected override void OnLeave()
    {
        SwitchOn(Disable);
        SwithchOff(Enable);
    }
}
