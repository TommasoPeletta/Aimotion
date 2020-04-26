using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;


public class PauseGame : MonoBehaviour
{
	
	public bool Paused = false;
	public GameObject ThePlayer;
	public GameObject PauseMenu;
    public GameObject Gun;

    // Update is called once per frame
    void Update()
    {
	if(Input.GetButtonDown("Cancel")){
		if (Paused == false){
                Cursor.visible = true;
                Time.timeScale = 0;
			Paused = true;
			PauseMenu.SetActive(true);
			ThePlayer.GetComponent<FirstPersonController>().enabled = false;
            Gun.GetComponent<GunFire>().enabled = false;

           
		}
		else{
			ThePlayer.GetComponent<FirstPersonController>().enabled = true;
            Gun.GetComponent<GunFire>().enabled = true;

                Paused = false;
			PauseMenu.SetActive(false);
			Time.timeScale = 1;
		}
	}
        
    }
	public void UnpausedGame(){
		ThePlayer.GetComponent<FirstPersonController>().enabled = true;
        Gun.GetComponent<GunFire>().enabled = true;

        Paused = false;
		PauseMenu.SetActive(false);
		Time.timeScale = 1;
	}
    public void Exit()
    {
       
        Paused = false;
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
        
    }

}
