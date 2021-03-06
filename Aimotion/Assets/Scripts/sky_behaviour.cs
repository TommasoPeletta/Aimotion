﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sky_behaviour : MonoBehaviour
{


public Material[] skyboxes;
public int x = 0;
public int state = 0; // 0 for normal and 1 for thunder
public int normalSky = 0;
public int thunderSky = 0;
public int x_old = 0;

// Use this for initialization
 void Start () {
    ChangeMySkybox();
 }
 
 // Update is called once per frame
 void Update () {
	x = LevelBehaviour.level;
	if (x != x_old){
		ChangeMySkybox();
		normalSky = 0;
		thunderSky = 0;
	}
	if (x == 4 & state == 0){
		normalSky = normalSky + 1;
		if (normalSky == 300){
			thunder();
			state = 1;
		}
	}
	if (x == 4 & state == 1){
		thunderSky = thunderSky + 1;
		if (thunderSky == 10){
			normalSky = 0;
			thunderSky = 0;
			normal();
			state = 0;
		}
	}
    x_old = x;
 }

void ChangeMySkybox()
 {
    //x = Random.Range(0, skyboxes.Length-1);
    RenderSettings.skybox = skyboxes[x];
	DynamicGI.UpdateEnvironment ();
 }

void thunder(){
	RenderSettings.skybox = skyboxes[skyboxes.Length-1];
	DynamicGI.UpdateEnvironment ();
	
}

void normal(){
	RenderSettings.skybox = skyboxes[skyboxes.Length-2];
	DynamicGI.UpdateEnvironment ();
	
}






}
