using UnityEngine;
using System.Collections;

public class Cameras: MonoBehaviour {
	
	public Camera cam1;
	public Camera cam2; 
	public Camera cam3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >50f) {
			cam1.enabled = false; 
			cam2.enabled = true; 
	
	}
		Debug.Log(Time.time);
		
	}
	void OnTriggerEnter() {
		cam3.enabled =true;
	}
}