using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene02 : MonoBehaviour {

	/*
	 * READ FOR MORE DETAILS:
	 * Use this script to load a scene of your choice. Be sure your scene is in the BUILD SETTINGS > SCENES IN BUILD. 
	 * Your first scenes should always Be the MENU + LEVEL SELECTION SCREEN which are level 1 and level 2 (If you want them in your game)
	 * Change the +1 to anything to load another level. EXAMPLE: Change SceneManager.LoadScene(+1); to SceneManager.LoadScene(+2);
	 * to load the level 2. You can see the levels on the right in the FILE > BUILD SETTINGS > SCENES IN BUILD next to the scenes.
	*/

	void OnMouseDown() {
		SceneManager.LoadScene(+2);
	}
}
