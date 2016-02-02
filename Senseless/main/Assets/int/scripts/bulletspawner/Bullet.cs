using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Bullet : MonoBehaviour {

    public Vector3 direction;
    public Transform endExplosion;

    private bool stopped = false;
	
	// Update is called once per frame
	void Update () {

        transform.Translate(direction);

    }

    void OnTriggerEnter(Collider other)
    {
        if (stopped)
        {
            return;
        }
        if (other.GetComponent<Bullet>() != null)
        {
            return;
        }

        BulletReceiver receiver = other.gameObject.GetComponent<BulletReceiver>();

        if (receiver != null)
        {
            receiver.Receive();
        }

        if (other.GetComponent<FirstPersonController>() != null)
        {
            Sense sense = Root.Instance.SenseManager.GetBossSense();
            if (sense == null)
            {
                Application.LoadLevel("StartScreen");
            }
            else
            {
                sense.Off(null);
            }
        }

        if (endExplosion != null)
        {
            endExplosion = Instantiate(endExplosion);
            endExplosion.transform.position = transform.position;
        }
        foreach(ParticleSystem pat in GetComponentsInChildren<ParticleSystem>())
        {
            pat.Stop();
        }

        stopped = true;
        StartCoroutine(DestroyObj());
    }

    IEnumerator DestroyObj()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
