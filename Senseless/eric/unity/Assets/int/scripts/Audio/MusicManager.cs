using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

    public AudioClip mainTheme;
    public AudioClip ambience;
    public AudioClip creep1;
    public AudioClip creep2;
    public AudioClip creep3;
    public AudioClip[] creepArray = new AudioClip[3];

    void Start()
    {
        PlayMainTheme();
        
        creepArray[0] = creep1;
        creepArray[1] = creep2;
        creepArray[2] = creep3;

    }

    public void PlayMainTheme()
    {
        AudioManager.instance.PlayMusic(mainTheme, 2);
    }

    public void PlayAmbience()
    {
        AudioManager.instance.PlayMusic(ambience, 2);
    }

    public void PlayCreep()
    {
        int i = Random.Range(0,2);
        AudioManager.instance.PlayMusic(creepArray[i], 1);
    }

	// Use this for initialization
	

}
