using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onLoginButtonClick ()
    {
        print("onLoginClick");
        string userName = GameObject.Find("UserName").GetComponent<InputField>().text;
        string userPW = GameObject.Find("UserPW").GetComponent<InputField>().text;
        print("userName : " + userName);
        print("userPW : " + userPW);
        PlayerPrefs.SetString("userName", userName);
        SceneManager.LoadScene("Courses");
    }

}
