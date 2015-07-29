using UnityEngine;
using System.Collections;

public class RotateBump : MonoBehaviour {

	public float i = 0.7f;
	public bool c = true ;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	


		this.gameObject.transform.localScale = new Vector3(i,i,0);
		if (c == true)
			i += 0.003f;
		else
			i -= 0.003f;

		if (i > 0.9f)
			c = false;

		if (i == 0.7f)
			c = true; 
	}
}
