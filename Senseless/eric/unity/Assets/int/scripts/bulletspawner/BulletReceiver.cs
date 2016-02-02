using UnityEngine;
using System.Collections;

public class BulletReceiver : MonoBehaviour {

    public void Receive()
    {
        Animator anim = GetComponent<Animator>();

        if (anim != null)
        {
            anim.SetTrigger("Break");
        };

        foreach(Rigidbody body in GetComponentsInChildren<Rigidbody>())
        {
            body.constraints = RigidbodyConstraints.None;
            body.AddTorque(new Vector3(20, 0, 10));
        }
    }
}
