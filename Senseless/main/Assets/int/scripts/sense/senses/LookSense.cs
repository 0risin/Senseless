using UnityEngine;
using System.Collections;

public class LookSense : Sense
{

    public override void On(Trigger trigger)
    {
        enable("look");
        disable("blind");

        base.On(trigger);
        Debug.Log("LookSense");
    }

    public override void Off(Trigger trigger)
    {
        enable("blind");
        disable("look");

        base.Off(trigger);
    }
}
