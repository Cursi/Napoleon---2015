using UnityEngine;
using System.Collections;

public class XClick : MonoBehaviour {

	public GameObject par1;
	public GameObject x;
	public bool dute = false;

	public AudioClip a;

	public GameObject slide ;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (dute)
		{
			par1.transform.Translate (-0.5f, 0, 0);
			x.transform.Translate (-0.5f, 0, 0);

			if (par1.transform.position.x ==-20f)
			{
				dute = false;
			}

		}
	}

	void OnMouseDown()
	{
		ConclAudio.executa = true ;

		slide.GetComponent<AudioSource>().Stop();
		Audio.isPlaying = false;

		GetComponent<AudioSource>().clip = a;
		GetComponent<AudioSource>().Play();

		Move.tunea = false;
		dute = true;
	}
}
