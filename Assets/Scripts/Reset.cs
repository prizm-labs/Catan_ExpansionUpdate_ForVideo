using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			Debug.Log ("We pressed the Q Key");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	
	}
}
