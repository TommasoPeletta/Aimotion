using UnityEngine;
﻿using System.Collections;
using System.Collections.Generic;

public class HelloClient : MonoBehaviour{

	public float info = 0;
	private HelloRequester _helloRequester;
	public bool check = false;


	private void Update(){
		if (Input.GetKeyDown("x")) {
			_helloRequester = new HelloRequester();
			_helloRequester.Start();
		}
		info = HelloRequester.bpm;
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
