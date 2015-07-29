using UnityEngine;
using System.Collections;

public class ConclAudio : MonoBehaviour {

	public AudioClip a ;
	public static bool executa = true ;
	public static bool isPlaying = false ;
	public static int x = 0 ;

	public GameObject inf;

	// Use this for initialization
	void Start () 
	{
		inf = GameObject.Find ("infoingame");
		GetComponent<AudioSource>().clip = a;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		if (executa == true) 
		{

			if (x % 2 == 0)
			{
				if (InfoClick.isPlaying == true) 
				{
					inf.GetComponent<AudioSource> ().Stop ();
					InfoClick.isPlaying = false ;
				}

				isPlaying = true ;
				GetComponent<AudioSource> ().Play ();
			}
			else
			{
				isPlaying = false ;
				GetComponent<AudioSource> ().Stop ();
			}

			x++;
		}
	}
}
