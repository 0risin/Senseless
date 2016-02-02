using UnityEngine;
using System.Collections;

public class FeelSense : Sense {

    public override bool DefaultEnabled
    {
        get
        {
            return false;
        }
    }
    public override void On(Trigger trigger)
    {
        disable("feel");

        base.On(trigger);
    }

    public override void Off(Trigger trigger)
    {
        enable("feel");

        base.Off(trigger);
    }
}
