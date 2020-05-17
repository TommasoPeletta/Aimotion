using UnityEngine;
﻿using System.Collections;
using System.Collections.Generic;

public class HelloClient : MonoBehaviour{

	public float info = 0;
	private HelloRequester _helloRequester;
	public bool check = false;
    public float time = 1;


	private void Update(){
        if (!PauseGame.Paused2)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                _helloRequester = new HelloRequester();
                _helloRequester.Start();
                time = 1;
            }
            info = HelloRequester.bpm;
        }
	}


	private void OnDestroy(){
		_helloRequester.Stop();
	}



	IEnumerator EnableClient() {
		yield return new WaitForSeconds(2.0f);
		check = true;
	}


	IEnumerator EnableWait() {
		yield return new WaitForSeconds(5.0f);
		check = true;
	}
}
