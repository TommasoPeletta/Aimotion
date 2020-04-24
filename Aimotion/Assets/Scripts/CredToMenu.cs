using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CredToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
	StartCoroutine(ReturnToMenu());
        
    }

	IEnumerator ReturnToMenu(){
		yield return new WaitForSeconds(9);
		SceneManager.LoadScene(1);
	}
}
