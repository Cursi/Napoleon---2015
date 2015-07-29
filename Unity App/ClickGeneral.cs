using UnityEngine;
using System.Collections;

public class ClickGeneral : MonoBehaviour {

	public float fadeTime;
	public bool fMusic = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (fMusic == true ) 
			if (AudioListener.volume >0)
			AudioListener.volume -= 0.025f;
		
	}

	IEnumerator  OnMouseDown()
	{	

		if (this.gameObject.name == "m1") // story
		{	
			fMusic = true;
			fadeTime = GameObject.Find ("Main Camera").GetComponent<Fading> ().BeginFade (1);
			yield return new WaitForSeconds (fadeTime);				
			Application.LoadLevel ("Game");
		}

		if (this.gameObject.name == "m2") // test
		{	
			fMusic = true;
			fadeTime = GameObject.Find ("Main Camera").GetComponent<Fading> ().BeginFade (1);
			yield return new WaitForSeconds (fadeTime);	
			Application.OpenURL(Application.dataPath + "/Site/index.html");
			Application.Quit ();
		}

		if (this.gameObject.name == "x") // x
		{
			fMusic = true;
			fadeTime = GameObject.Find ("Main Camera").GetComponent<Fading> ().BeginFade (1);
			yield return new WaitForSeconds (fadeTime);				
			Application.Quit();
		}

		//-----------------------------------------------------------------------------------

		if (this.gameObject.name == "backin") // story
		{	
			fMusic = true;
			fadeTime = GameObject.Find ("Main Camera").GetComponent<Fading> ().BeginFade (1);
			yield return new WaitForSeconds (fadeTime);				
			Application.LoadLevel ("home");
		}

	}
}
