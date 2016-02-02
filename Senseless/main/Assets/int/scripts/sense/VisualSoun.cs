using UnityEngine;
using System.Collections;

public class VisualSoun : MonoBehaviour {

    // Use this for initialization
    public Camera m_Camera;
    public SpriteRenderer MySprite;
    public float scaleFactor = 1;
    private float SpriteScale;
    private float timepassed;
    private float timeneeded;
    void Start()
    {
        SpriteScale = 0;
        if(m_Camera==null)
        {
            m_Camera = Camera.main;
        }
        timeneeded = Random.Range(0.5f, 1.6f);
    }
    
    void Update()
    {
        transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.forward,
            m_Camera.transform.rotation * Vector3.up);
        SpriteScale = Mathf.Lerp(0f, 1f, timepassed / 3);
        SpriteScale *= scaleFactor;
        gameObject.GetComponent<SpriteRenderer>().transform.localScale = new Vector3(SpriteScale, SpriteScale, SpriteScale);
        timepassed += Time.deltaTime;
        
        if (timepassed > timeneeded)
        {
            timepassed = 0;
            timeneeded = Random.Range(0.5f, 1.6f);
        }
    }
}