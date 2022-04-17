using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {


	void Update () 
	transform.rotation = Quanterion.Euler(0,0,0);
	{
		if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(new Vector2(0, 0.5f));
        }
	}
}
