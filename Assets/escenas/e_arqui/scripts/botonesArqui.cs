using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class botonesArqui : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void regresarMenuPrincipal(){
		// get the current scene name 
		//string sceneName = SceneManager.GetActiveScene().name;

		// load the same scene
		SceneManager.LoadScene("menu",LoadSceneMode.Single);
	}
}