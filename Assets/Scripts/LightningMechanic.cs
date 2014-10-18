﻿using UnityEngine;
using System.Collections;

public class LightningMechanic : MonoBehaviour {
	private bool flash = false;
	public float maxIntensity = 8;
	public float lightSpeed = 1.5f;
	public int flashChance = 0;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Random.Range (0, flashChance) == 5)
			flash = true;

		if (flash == true) {
			if (light.intensity < maxIntensity) {
				light.intensity += lightSpeed;
			}else{
				audio.Play ();
				flash = false;
			}
		} else {
			if (light.intensity > 0) {
				light.intensity -= lightSpeed;
			} else {
				light.intensity -= 0;
			}
		}
	}
}
