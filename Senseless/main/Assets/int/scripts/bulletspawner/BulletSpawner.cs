using UnityEngine;
using System.Collections;

public class BulletSpawner : MonoBehaviour {

    public GameObject bullet;
    public float spawnDegree = 11.25f;
    public float rotateSpeed = 0;

    private int lastRotIndex = 0;
    private float startTime;
    
    void Start()
    {
        startTime = Time.time;
    } 

	
	// Update is called once per frame
	void Update () {

        float timeLeft = Time.time - startTime;

        transform.eulerAngles += new Vector3(0, (rotateSpeed + timeLeft * 0.5f) * Time.deltaTime, 0);

        float currentY = transform.rotation.eulerAngles.y;
        int rotIndex = (int)(currentY / (spawnDegree / Mathf.Max(1, Mathf.Floor(timeLeft / 5))));

        if (rotIndex != lastRotIndex)
        {
            lastRotIndex = rotIndex;

            GameObject obj = Instantiate(bullet);
            obj.transform.rotation = transform.rotation;
            obj.transform.position = transform.position;
            obj.GetComponent<Bullet>().direction = transform.forward * 0.4f;

        }
	}
}
