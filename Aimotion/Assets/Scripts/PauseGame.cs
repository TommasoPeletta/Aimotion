﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseGame : MonoBehaviour
{
	
	public bool Paused = false;
	public GameObject ThePlayer;
	public GameObject PauseMenu;

    // Update is called once per frame
    void Update()
    {
	if(Input.GetButtonDown("Cancel")){
		if (Paused == false){
			Time.timeScale = 0;
			Paused = true;
			PauseMenu.SetActive(true);
			ThePlayer.GetComponent<FirstPersonController>().enabled = false;
			Cursor.visible = true;
		}
		else{
			ThePlayer.GetComponent<FirstPersonController>().enabled = true;
			Paused = false;
			PauseMenu.SetActive(false);
			Time.timeScale = 1;
		}
	}
        
    }
	public void UnpausedGame(){
		ThePlayer.GetComponent<FirstPersonController>().enabled = true;
		Paused = false;
		PauseMenu.SetActive(false);
		Time.timeScale = 1;
	}
}
