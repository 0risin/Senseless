using UnityEngine;
using System.Collections;

public class DoubleSwitcher : Trigger {

    public Sense.Type Enable;
    public Sense.Type Disable;
    public Sense.Type Enable2;
    public Sense.Type Disable2;

    protected override void OnEnter()
    {
        SwitchOn(Enable);
        SwithchOff(Disable);
        SwitchOn(Enable2);
        SwithchOff(Disable2);
    }
}
