using UnityEngine;
using System.Collections;

public class Fish : MonoBehaviour {
	
	public Vector3 destination = new Vector3( 100f, 100f, 0f);
	public float speed = 5f; //now ther's a speed mode 
	
	// Use this for initialization
	void Start () {
		InvokeRepeating("SetNewDestination", 0f, 15f);  //keep repeating __ function, after delay of 0s, repeat every 15 s
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.LookRotation(rigidbody.velocity); //so it faces the right way
	
	}
	
	void FixedUpdate() { //destination is already a position
		//rigidbody.AddForce( destination - transform.position );//food.position - fish.postion 
		Vector3 direction = Vector3.Normalize ( destination - transform.position);
		rigidbody.AddForce( direction * speed, ForceMode.Acceleration ) ; //and now there's a speed mode
	}
	
	void SetNewDestination () {
		//set a random destination 
		destination = Random.insideUnitSphere * 100f;
	}
}
