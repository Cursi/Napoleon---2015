using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour 	{

	public GameObject rosu;

	public float pasx, pasy, p = 30f;
	public bool c = false; 
	public static bool tunea = false; //there is tunea
	public bool terminat = false ;
	public GameObject par1;
	public GameObject x;

	public AudioClip a;

	public Sprite rr1; 
	public Sprite rr2;
	public Sprite rr3; 
	public Sprite rr4;
	public Sprite rr5; 
	public Sprite rr6;
	public Sprite rr7; 
	public Sprite rr8;

	public SpriteRenderer spriteRenderer;

	public GameObject concl;

	void Start () 
	{
		concl = GameObject.Find ("concl");
	}

	void Update () 
	{
		if (c) 
		{
			p--;
			rosu.transform.Translate(pasx, pasy, 0);
			if (p <=0) 
			{
				p=30f;
				c = false ;
				terminat = true;
			}
		}

		if (terminat == true) 
		{	
			if ( par1.transform.position.x >= -20f )
			{	
				par1.transform.Translate (0.5f, 0, 0);
				x.transform.Translate (0.5f, 0, 0);

				if (par1.transform.position.x==0)
				{
					terminat = false;
				}
			}
		}
	}

	void OnMouseDown()
	{
		if (!c && tunea == false) 
		{	
			if ( ConclAudio.isPlaying == true) 
			{
				concl.GetComponent<AudioSource> ().Stop ();
				ConclAudio.x++;
			}

			if (this.gameObject.name == "r1") spriteRenderer.sprite = rr1;
			if (this.gameObject.name == "r2") spriteRenderer.sprite = rr2;
			if (this.gameObject.name == "r3") spriteRenderer.sprite = rr3;
			if (this.gameObject.name == "r4") spriteRenderer.sprite = rr4;
			if (this.gameObject.name == "r5") spriteRenderer.sprite = rr5;
			if (this.gameObject.name == "r6") spriteRenderer.sprite = rr6;
			if (this.gameObject.name == "r7") spriteRenderer.sprite = rr7;
			if (this.gameObject.name == "r8") spriteRenderer.sprite = rr8;

			GetComponent<AudioSource>().clip = a;
			GetComponent<AudioSource>().Play();

			pasx = ( this.transform.position.x - rosu.transform.position.x ) / 30 ; 
			pasy = ( this.transform.position.y - rosu.transform.position.y ) / 30 ; 
			c = true; tunea = true ;
		}

	}
									}
