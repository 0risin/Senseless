using UnityEngine;
using System.Collections;

public class SenseSystem : MonoBehaviour {

    public Transform[] layerItems;

    public GameObject GetLayerItem(string name)
    {
        foreach(Transform t in layerItems)
        {
            if (t.name == name)
            {
                return t.gameObject;
            }
        }
        return null;
    }

	// Use this for initialization
	void Start () {
        Root.Instance.SenseManager.SetDefault();
	}

    void Update()
    {
        Root.Instance.SenseManager.Update();

        if (Root.Instance.Input.Back)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
