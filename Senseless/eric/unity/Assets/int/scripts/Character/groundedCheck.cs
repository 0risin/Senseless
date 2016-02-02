using UnityEngine;
using System.Collections;

public class groundedCheck : MonoBehaviour {

    public bool isGrounded;

    // Update is called once per frame


    void OnTriggerStay(Collider other)
    {
        if(!other.CompareTag("Player"))
        isGrounded = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
            isGrounded = false;
    }
}
