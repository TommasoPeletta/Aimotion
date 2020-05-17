using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour
{
    private bool check = false;
    // Start is called before the first frame update
    void Start()
    {
	StartCoroutine (SplashFinish());
        
    }

    void Update()
    {
        if (check)
        {
            if (HelloRequester.bpm != 0)
            {
                SceneManager.LoadScene(1);
            }
        }
    }

	IEnumerator SplashFinish(){
		yield return new WaitForSeconds(5);
        check = true;
	}
}
