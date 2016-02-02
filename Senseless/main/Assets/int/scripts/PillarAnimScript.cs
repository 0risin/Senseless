using UnityEngine;
using System.Collections;

public class PillarAnimScript : MonoBehaviour
{

    Animator anim;
    bool on = false;

    // Update is called once per frame



    void OnTriggerStay(Collider other)
    {
        anim = GetComponent<Animator>();
        anim.SetTrigger("Break");
    }
}
