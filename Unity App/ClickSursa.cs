using UnityEngine;
using System.Collections;

public class ClickSursa : MonoBehaviour {

	public GameObject info;
	public bool dute = false;
	public bool unde = false ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (dute)
		{
			if (unde == false) // jos ---- sus
		{
			info.transform.Translate (0.5f,0, 0);
			
			if (info.transform.position.x ==-6f)
			{
				dute = false;
				unde = true ;
			}
			
		}	else
			
			{
				info.transform.Translate (-0.5f,0, 0);
				
				if (info.transform.position.x == -18f)
				{
					dute = false;
					unde = false ;
				}

			}
			
		}
	}

	void OnMouseDown()
	{
		dute = true;
	}
}
