using UnityEngine;
using System.Collections;

public class Orientation : Sense
{

    public override bool DefaultEnabled
    {
        get
        {
            return false;
        }
    }

    // Use this for initialization
    void Start()
    {

    }
    public override void On(Trigger trigger)
    {
        base.On(trigger);
    }

    public override void Off(Trigger trigger)
    {
        base.Off(trigger);
    }
}