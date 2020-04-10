using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
		AudioSource gunsound = GetComponent<AudioSource>();
		gunsound.Play();
		Animation gunshot = GetComponent<Animation>();
		gunshot.Play("GunShot");
	}

    }
}
