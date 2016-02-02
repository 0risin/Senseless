using UnityEngine;
using System.Collections;

public class PillarAnimation : MonoBehaviour
{
    Animator anim;
   void OnTriggerEnter(Collider other)
    {
        anim = GetComponent<Animator>();
        anim.SetTrigger("Break");
    }
}
