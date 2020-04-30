using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_behaviour : MonoBehaviour
{

    public AudioSource[] AudioVector;
    public int r = 0;
    public int r_new;

    // Start is called before the first frame update
    void Start()
    {
        AudioVector[0].time = 4.0f;
        AudioVector[r].Play();        
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseGame.soundpause)
        {
            AudioVector[r].Pause();
            PauseGame.soundpause = false;
        }

        if (PauseGame.soundresume)
        {
            AudioVector[r].UnPause();
            PauseGame.soundresume = false;
        }

        if (Input.GetKeyDown(KeyCode.S)){
            r_new = Random.Range(0, AudioVector.Length);
            PlayAudio();
            r = r_new;
	}
    }

    void PlayAudio()
    {
        AudioVector[0].time = 4.0f;
        AudioVector[r].Stop();
        AudioVector[r_new].Play();

    }
}
