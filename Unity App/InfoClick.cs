using UnityEngine;
using System.Collections;

public class InfoClick : MonoBehaviour {

	public GameObject concl;
	public static bool isPlaying = false ;

	// Use this for initialization
	void Start () 
	{
		concl = GameObject.Find ("concl");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public AudioClip p;

	void OnMouseDown()

	{
		if (Audio.isPlaying == false)
		{
			if (ConclAudio.isPlaying == true) 
			{
				ConclAudio.isPlaying = false;
				concl.GetComponent<AudioSource> ().Stop ();
				ConclAudio.x++;
			}

			GetComponent<AudioSource> ().clip = p;
			GetComponent<AudioSource> ().Play ();
			isPlaying = true;
		}
	}
}
