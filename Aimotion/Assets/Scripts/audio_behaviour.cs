using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_behaviour : MonoBehaviour
{

  public AudioSource[] AudioVector;
  public static int r = 0;
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
          if (r == 3)
          {
              AudioVector[1].Pause();
          }
          PauseGame.soundpause = false;
      }

      if (PauseGame.soundresume)
      {
          AudioVector[r].UnPause();
          if (r == 3)
          {
              AudioVector[1].UnPause();
          }
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
      if (r == 3)
      {
          AudioVector[1].Stop();
      }
      if (r_new == 3)
      {

          AudioVector[r_new].Play();
          AudioVector[1].Play();

      }
      else
      {
          AudioVector[r_new].Play();
      }


  }
}
