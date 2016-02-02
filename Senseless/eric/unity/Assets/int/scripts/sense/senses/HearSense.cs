using UnityEngine;
using System.Collections;

public class HearSense : Sense
{

    public override void On(Trigger trigger)
    {
        enable("hear");

        base.On(trigger);
        Debug.Log("HearSense");
    }

    public override void Off(Trigger trigger)
    {
        disable("hear");

        base.Off(trigger);
    }
}
