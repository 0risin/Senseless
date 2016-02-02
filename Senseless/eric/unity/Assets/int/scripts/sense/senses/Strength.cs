using UnityEngine;
using System.Collections;

public class Strength : Sense {

	// Use this for initialization
	void Start () {
	    
	}
    public override void On(Trigger trigger)
    {
        base.On(trigger);
        Debug.Log("sadfasgd");
    }

    public override void Off(Trigger trigger)
    {
        base.Off(trigger);
        Debug.Log("9999");
    }
}
