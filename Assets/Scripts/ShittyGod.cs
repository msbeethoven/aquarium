using UnityEngine;
using System.Collections;
using System.Collections.Generic; //import some code that Unity wrote, will allow lists 

public class ShittyGod : MonoBehaviour {
	
	public Fish  fishBlueprint; //refers to other fish, reserves a fish shaped hole in it's hear that calls it. like the camera rigidbody frum b4
	//public Fish fishBlueprint2;
	//public Fish fishBlueprint3;
	public int fishCount =100; 
	
	public List<Fish> fishList = new List<Fish>(); 
	
	
	// Use this for initialization. // want all the fish spaw at the beginning of game 

void Start () {
		int currentFishCounter = 0;
		while ( currentFishCounter < fishCount ) { //if while is true, will execute code. if not, after
			// this spawns a fish
			float fishtype = Random.value;
			Vector3 fishPosition = new Vector3( Random.Range (-10f,10f),Random.Range (-10f,10f), Random.Range (-10f,10f)); //makes new var. remember these 3, is what it's generating
			//Instantiate(fishBlueprint, fishPosition, Quaternion.identity); //quatidentity is 0,0,0
			if (fishtype < .5){ 
				Fish newFish = Instantiate(fishBlueprint, fishPosition, Quaternion.identity) as Fish; //as fish tells unity to treat instantiate as a fish
				fishList.Add (newFish);
			//}else if(fishtype < .9){
				//Fish newFish = Instantiate(fishBlueprint2, fishPosition, Quaternion.identity) as Fish;
				//fishList.Add (newFish);
			//}else{
				//Fish newFish = Instantiate(fishBlueprint3, fishPosition, Quaternion.identity) as Fish;
				//fishList.Add (newFish);
			}
				//float random = Random.Range(0f, 10f);
			//if (random >5f) {
				 
			//both below increment out fishCounter
			//currentFishCounter = currentFishCounter + 1; 

			currentFishCounter++; //increments the fish by one, does the code, increase by one, etc. unil 100 because 100 is not less than 100
		}
		//when currentfishcounter is 100, the code will end the while() loop and do whatever code is after it, like righ here 
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKey( KeyCode.Space )){
			foreach ( Fish currentFish in fishList ){
				currentFish.destination = Vector3.zero;
			}
			fishBlueprint.destination = Vector3.zero;
			//fishBlueprint2.destination = Vector3.zero;
			//fishBlueprint3.destination = Vector3.zero;

		}
	}
}
//put this on an emptygameobject
