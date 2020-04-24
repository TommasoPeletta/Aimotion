using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour
{
	public void PlayGame () {
		SceneManager.LoadScene(2);
        Reset();
    }

    public void Reset()
    {
        Spawner.targetSpawned = 0;
        GlobalAmmo.CurrentAmmo = 300;
        GlobalAmmo.LoadedAmmo = 0;
        GlobalScore.CurrentScore = 0;
    }

	public void CreditScene () {
		SceneManager.LoadScene(3);
	}

    public void ExitApplication()
    {
        Application.Quit();
    }
}
