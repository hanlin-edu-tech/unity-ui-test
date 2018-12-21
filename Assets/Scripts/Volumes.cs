using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumes : MonoBehaviour {

    public GameObject Missile;

    GameObject airplan;

    // Use this for initialization
    void Start () {
        airplan = GameObject.Find("Airplan");
        GameObject.Find("SubjectTitle").GetComponent<Text>().text = PlayerPrefs.GetString("subject");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPowButtonClick ()
    {
        GameObject missile = Instantiate(Missile);
        missile.transform.SetPositionAndRotation(airplan.transform.position, airplan.transform.rotation);
    }
}
