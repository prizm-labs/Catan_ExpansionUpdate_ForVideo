using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TouchScript;
using TouchScript.Behaviors;
using TouchScript.Gestures;
using System;

public class TapGetUpdates : MonoBehaviour {

	public GameObject whiteScrim;
	public GameObject Green_PlayerDock;
	public GameObject Red_PlayerDock;
	public GameObject Yellow_PlayerDock;
	public GameObject Blue_PlayerDock;
	public GameObject PirateTracker;
	public GameObject EventDie;


	void OnEnable(){
		GetComponent<PressGesture> ().Pressed += TakeOutUpdateScreen;
	}

	void OnDisable(){
		GetComponent<PressGesture> ().Pressed -= TakeOutUpdateScreen;
	}

	public void TakeOutUpdateScreen(object sender, EventArgs e) {
		StartCoroutine ("ExpansionDisappear");
	}


	public IEnumerator ExpansionDisappear(){

		GetComponent<SpriteRenderer> ().enabled = true;
		yield return new WaitForSeconds (0.5f);
		GetComponent<SpriteRenderer> ().enabled = false;
		transform.parent.GetComponent<Animator> ().SetInteger ("Expansion", 2);
		yield return new WaitForSeconds (2.0f);
		whiteScrim.GetComponent<SpriteRenderer> ().color = new Color (whiteScrim.GetComponent<SpriteRenderer> ().color.r, whiteScrim.GetComponent<SpriteRenderer> ().color.g, whiteScrim.GetComponent<SpriteRenderer> ().color.b, 0.2f);
		//yield return new WaitForSeconds (2.0f);
		Green_PlayerDock.GetComponent<Animator> ().SetInteger ("Bounce", 1);
		yield return new WaitForSeconds (0.1f);
		Red_PlayerDock.GetComponent<Animator> ().SetInteger ("Bounce", 1);
		yield return new WaitForSeconds (0.2f);
		Yellow_PlayerDock.GetComponent<Animator> ().SetInteger ("Bounce", 1);
		yield return new WaitForSeconds (0.1f);
		Blue_PlayerDock.GetComponent<Animator> ().SetInteger ("Bounce", 1);
		yield return new WaitForSeconds (1.0f);
		PirateTracker.GetComponent<Animator> ().SetInteger ("Bounce", 1);
		EventDie.GetComponent<Animator> ().SetInteger ("Bounce", 1);


	}

}
