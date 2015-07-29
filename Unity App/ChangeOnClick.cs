using UnityEngine;
using System.Collections;

public class ChangeOnClick : MonoBehaviour {
	public Sprite sprite1; 
	public Sprite sprite2;

	public SpriteRenderer spriteRenderer; 
	public int v = 1 ;

	public bool terminat = true;

	// Use this for initialization
	void Start () 
	{
		AudioListener.volume = 1;

		spriteRenderer = GetComponent<SpriteRenderer>(); 
		if (spriteRenderer.sprite == null) 
			spriteRenderer.sprite = sprite1;
	}

	void Update()
	{
		if (terminat == false) 
		{
			if (v % 2 == 0) 
			{
					if (AudioListener.volume >0)
				AudioListener.volume -= 0.02f;
					else
				{
					spriteRenderer.sprite = sprite2;
					AudioListener.pause = true;
					v++;
					terminat = true;
				}
			} 
			else 
			{

				AudioListener.pause = false;
				spriteRenderer.sprite = sprite1;
				if (AudioListener.volume <1)
				AudioListener.volume += 0.02f;

				else 
				{

					v++;
					terminat = true ;
				}
			}
		}
	}

	void OnMouseDown()
	{

		terminat = false;


	}


}
