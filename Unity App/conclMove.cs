using UnityEngine;
using System.Collections;

public class conclMove : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		
	}

	public bool sus ;
	public float timer = 0.03f;
	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		if (this.gameObject.transform.position.y == -4.2f)
			sus = false;

		if (this.gameObject.transform.position.y == -3.9f)
			sus = true;


		if (sus == false && timer <= 0)
		{
			this.gameObject.transform.Translate (0, 0.02f, 0);
			timer = 0.03f;
		}

		if (sus == true && timer <= 0)
		{
			this.gameObject.transform.Translate (0, -0.02f, 0);
			timer = 0.03f;
		}
	}
}
