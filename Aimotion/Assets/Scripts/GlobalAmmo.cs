﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
    // Start is called before the first frame update
    public static float CurrentAmmo = 300;
	public float InternalAmmo;
	public GameObject AmmoDisplay;
	public static float LoadedAmmo = 200;
	public float InternalLoaded;
	public GameObject LoadedDisplay;
    void Start()
	{
		LoadedAmmo = 200;
	}
    void Update()
    {
    InternalAmmo = CurrentAmmo;
    AmmoDisplay.GetComponent<Text>().text = "" + InternalAmmo;

	InternalLoaded = LoadedAmmo;
	LoadedDisplay.GetComponent<Text>().text = "" + InternalLoaded;
    }
}
