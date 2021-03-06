//This script will wait 5.0 seconds and then fade the text out in a perfect 0.1 transition.

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisappearAfter : MonoBehaviour {

	void Start () {
        StartCoroutine(fadeOut());
	}

    IEnumerator fadeOut()
    {
		yield return new WaitForSeconds(5.0f); //The timer to wait until the text starts to fadeout. 5.0 = 5s
        float opacity = 1f;

        while (opacity > 0f)
        {
           // Debug.Log(opacity);
            opacity = opacity - 0.1f;
			this.GetComponent<TextMesh>().color = new Color(1f, 1f, 1f,opacity);
            yield return new WaitForSeconds(0.1f);
        }
        yield return null;
    }

	

}
