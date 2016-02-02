using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class ChangeLevel : MonoBehaviour
{
    public string Name;

    void OnTriggerEnter()
    {
        StartCoroutine(reload(1.0f));
    }

    private IEnumerator reload(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Application.LoadLevel(Name);
    }
}
