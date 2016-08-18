using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TouchScript;
using TouchScript.Behaviors;
using TouchScript.Gestures;
using System;

public class Tap4 : MonoBehaviour {

	public GameObject VictoryScreen;
	public GameObject UpdateScreen;


	void OnEnable(){
		GetComponent<PressGesture> ().Pressed += Step1_TakeOutVictoryScreen;
	}

	void OnDisable(){
		GetComponent<PressGesture> ().Pressed -= Step1_TakeOutVictoryScreen;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Step1_TakeOutVictoryScreen(object sender, EventArgs e) {
		StartCoroutine ("SwapVictoryForExpansion");


	}



	public IEnumerator SwapVictoryForExpansion(){
		//Shrink victory screen and red 4
		VictoryScreen.GetComponent<Animator> ().SetInteger ("Victory_Actions", 1);

		yield return new WaitForSeconds (1.0f); 

		//Pop up Expansion Modal
		UpdateScreen.GetComponent<Animator> ().SetInteger ("Expansion", 1);
	}


}
