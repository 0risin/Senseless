using UnityEngine;
using System.Collections;

public class SenseDebug : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        ////Debug Key Sense triggers
        if (Input.GetKeyDown("u"))
        {
            Sense s = Root.Instance.SenseManager.GetSense(Sense.Type.Look);
            if (!s.Active)
            {
                s.On(null);
            }
            else
            {
                s.Off(null);
            }
        }
        if (Input.GetKeyDown("i"))
        {
            Sense s = Root.Instance.SenseManager.GetSense(Sense.Type.Gravity);
            if (!s.Active)
            {
                s.On(null);
            }
            else
            {
                s.Off(null);
            }
        }
        if (Input.GetKeyDown("o"))
        {
            Sense s = Root.Instance.SenseManager.GetSense(Sense.Type.Feel);
            if (!s.Active)
            {
                s.On(null);
            }
            else
            {
                s.Off(null);
            }
        }
        if (Input.GetKeyDown("p"))
        {
            Sense s = Root.Instance.SenseManager.GetSense(Sense.Type.Hear);
            if (!s.Active)
            {
                s.On(null);
            }
            else
            {
                s.Off(null);
            }
        }
        if (Input.GetKeyDown("j"))
        {
            Sense s = Root.Instance.SenseManager.GetSense(Sense.Type.Strength);
            if (!s.Active)
            {
                s.On(null);
            }
            //else
            //{
            //    s.Off();
            //}
        }
    }
}
