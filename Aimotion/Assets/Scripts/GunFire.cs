using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
	public HandgunRealoding ReloadingComponent;
	public static bool fireing = true;
    public static int totalshots = 0;
    public bool info;

    // Start is called before the first frame update
    void Start()
    {
        ReloadingComponent = GetComponent<HandgunRealoding>();
	fireing = true;
    }

    // Update is called once per frame
    void Update()
    {
        info = fireing;
	if(GlobalAmmo.LoadedAmmo>=1){
        if(Input.GetButtonDown("Fire1")){
                totalshots += 1;
		AudioSource gunsound = GetComponent<AudioSource>();
		gunsound.Play();
		Animation gunshot = GetComponent<Animation>();
		gunshot.Play("GunShot");
		GlobalAmmo.LoadedAmmo -= 1;
		Actionfire();
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
void Actionfire () {
		ReloadingComponent.enabled=false;
		fireing = false;
		enabled=false;

}
}
