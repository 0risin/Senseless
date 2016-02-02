using UnityEngine;
using System.Collections;

public class Toggler : Trigger {

    public Sense.Type Type;

    protected override void OnEnter()
    {
        Toggle(Type);
    }
}
