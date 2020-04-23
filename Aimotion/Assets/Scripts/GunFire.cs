using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
	public HandgunRealoding ReloadingComponent;
	public static bool fireing = true;

    // Start is called before the first frame update
    void Start()
    {
        ReloadingComponent = GetComponent<HandgunRealoding>();
	fireing = true;
    }

    // Update is called once per frame
    void Update()
    {	
	if(GlobalAmmo.LoadedAmmo>=1){
        if(Input.GetButtonDown("Fire1")){
		AudioSource gunsound = GetComponent<AudioSource>();
		gunsound.Play();
		Animation gunshot = GetComponent<Animation>();
		gunshot.Play("GunShot");
		GlobalAmmo.LoadedAmmo -= 1;
		ActionReload();
		StartCoroutine(EnableScripts());
		
	}
}
    }
IEnumerator EnableScripts () {
		yield return new WaitForSeconds(0.6f);
		enabled= true;
		ReloadingComponent.enabled=true;
		fireing = true;

}
void ActionReload () {
		ReloadingComponent.enabled=false;
		fireing = false;
		enabled=false;

}
}
