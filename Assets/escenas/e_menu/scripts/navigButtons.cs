using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class navigButtons : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ir_escenaArqui(){
		// get the current scene name 
		SceneManager.LoadScene("escenaArqui",LoadSceneMode.Single);

	}

	public void exit(){
		Application.Quit ();
	}
}