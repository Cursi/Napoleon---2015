using UnityEngine;
using System.Collections;

public class ChangeSprites : MonoBehaviour {
	public Sprite sprite1; 
	public Sprite sprite2;

	public SpriteRenderer spriteRenderer; 

	// Use this for initialization
	void Start () 
	{
		spriteRenderer = GetComponent<SpriteRenderer>(); 
		if (spriteRenderer.sprite == null) 
			spriteRenderer.sprite = sprite1;
	}

	void OnMouseEnter()
	{
		spriteRenderer.sprite = sprite2;
	}

	void OnMouseExit()

	{
		spriteRenderer.sprite = sprite1;
	}

}
