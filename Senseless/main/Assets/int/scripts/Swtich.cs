using UnityEngine;
using System.Collections;

public class Swtich : MonoBehaviour {

    public GameObject go;
        Animator anim;
        bool on = false;

	    void OnTriggerStay(Collider other)
        {
            if (Root.Instance.Input.Use){
                Debug.Log(on);
                on = !on;
                anim = GetComponent<Animator>();
                if (on)
                {
                    switchOn();
                } else
                {
                    switchOff();
                }
            }
            
        }

        void switchOn()
        {
            anim.SetTrigger("On");
            go.SetActive(true);
            Fade(0f, 1f, go);
        }

    void switchOff()
    {
        anim.SetTrigger("Off");
        Fade(1f, 0f, go);
        go.SetActive(false);
    }

    void Fade(float startAlpha, float targetAlpha, GameObject go){
        go.GetComponent<Renderer>().material.SetColor("_ALBEDO", new Color(1, 1, 1, Mathf.Lerp(startAlpha, targetAlpha, Time.deltaTime)));
    }
}
