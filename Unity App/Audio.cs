using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {

	public GameObject slide;
	public AudioClip i1;
	public AudioClip i2;
	public AudioClip i3;
	public AudioClip i4;
	public AudioClip i5;
	public AudioClip i6;
	public AudioClip i7;
	public AudioClip i8;

	public float timer = 1f;
	public bool fa = false ;

	public GameObject inf ;

	public static bool isPlaying = false ;

	// Use this for initialization
	void Start () 
	{
		inf = GameObject.Find ("infoingame");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (fa == true)
		{
			timer -= Time.deltaTime;

			if (timer <= 0) 
			{ 
				slide.GetComponent<AudioSource>().Play();
				isPlaying = true ;
				timer = 1f;
				fa = false ; 
			}
		}
	}

	void OnMouseDown()
	{
		if (InfoClick.isPlaying == true) 
		{
			inf.GetComponent<AudioSource> ().Stop ();
			InfoClick.isPlaying = false ;
		}

		ConclAudio.executa = false;

		if (this.gameObject.name == "r1") slide.GetComponent<AudioSource>().clip = i1;
		if (this.gameObject.name == "r2") slide.GetComponent<AudioSource>().clip = i2;
		if (this.gameObject.name == "r3") slide.GetComponent<AudioSource>().clip = i3;
		if (this.gameObject.name == "r4") slide.GetComponent<AudioSource>().clip = i4;
		if (this.gameObject.name == "r5") slide.GetComponent<AudioSource>().clip = i5;
		if (this.gameObject.name == "r6") slide.GetComponent<AudioSource>().clip = i6;
		if (this.gameObject.name == "r7") slide.GetComponent<AudioSource>().clip = i7;
		if (this.gameObject.name == "r8") slide.GetComponent<AudioSource>().clip = i8;

		fa = true;
	}
}
