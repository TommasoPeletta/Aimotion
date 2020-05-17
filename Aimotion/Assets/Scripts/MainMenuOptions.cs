using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour
{
    public static float bpm0;
	public void PlayGame () {
		SceneManager.LoadScene(2);
        Reset();
        bpm0 = HelloRequester.bpm;
        LevelBehaviour.level = 0;
    }

    public void Reset()
    {
        Time.timeScale = 1;
        Spawner.targetSpawned = 0;
        Spawner.spawnPosition = new Vector3(-18.78f, 12.58f, 40.34f);
        Spawner.index = 0;
        Spawner.timespawn = 5.0f;
        Spawner.initialtime = 5.0f;
        Spawner.targetSpawned = 0;
        Spawner.checktime = false;
        Spawner.missedTarget = 0;
        Spawner.playsound = false;
        GlobalAmmo.CurrentAmmo = 300;
        GlobalAmmo.LoadedAmmo = 0;
        GlobalScore.CurrentScore = 0;
        GunFire.totalshots = 0;
        LevelBehaviour.countlvl = 0;
        LevelBehaviour.level = 0;
    }

	public void CreditScene () {
		SceneManager.LoadScene(3);
	}

    public void ExitApplication()
    {
        Application.Quit();
    }
}
