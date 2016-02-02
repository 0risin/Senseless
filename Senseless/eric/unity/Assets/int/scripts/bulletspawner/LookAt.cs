using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour {

    public Transform target;

    void Update()
    {

        transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
    }
}
