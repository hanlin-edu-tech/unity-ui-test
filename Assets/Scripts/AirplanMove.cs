using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplanMove : MonoBehaviour {

    public float speed = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate((Vector2.left + Vector2.up) * speed * Time.deltaTime);
        this.transform.Rotate(Vector3.back);
    }
}
