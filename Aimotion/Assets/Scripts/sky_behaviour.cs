using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sky_behaviour : MonoBehaviour
{
/*
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

	public int level = 0;


    // Update is called once per frame
    void Update()
    {
	//if (level == 0)
	if (Input.GetKeyDown(KeyCode.M))
		if (RenderSettings.skybox.HasProperty("_Tint"))
			RenderSettings.skybox.SetColor("_Tint",Color.blue);
		else if (RenderSettings.skybox.HasProperty("_SkyTint"))
			RenderSettings.skybox.SetColor("_SkyTint",Color.blue);
	//else if (level == 1)
	else if (Input.GetKeyDown(KeyCode.M))
			RenderSettings.skybox.SetColor("_Tint",Color.red);
		else if (RenderSettings.skybox.HasProperty("_SkyTint"))
			RenderSettings.skybox.SetColor("_SkyTint",Color.red);
    }
*/

//public static void UpdateEnvironment();





public Material[] skyboxes;

// Use this for initialization
 void Start () {
    ChangeMySkybox();
 }
 
 // Update is called once per frame
 void Update () {
	if (Input.GetKeyDown(KeyCode.S))
		ChangeMySkybox();
 }

void ChangeMySkybox()
 {
    int x = Random.Range(0, skyboxes.Length);
    RenderSettings.skybox = skyboxes[x];
	DynamicGI.UpdateEnvironment ();
 }





}
