using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutDestroy : MonoBehaviour {

    public float radius = 10;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Mathf.Max(Mathf.Abs(this.transform.position.x), Mathf.Abs(this.transform.position.y)) > radius) {
            Destroy(gameObject);
        }
    }
}
