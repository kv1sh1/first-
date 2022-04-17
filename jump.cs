using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {


	void Update () {
		if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(new Vector2(0, 0.5f));
        }
	}
}
