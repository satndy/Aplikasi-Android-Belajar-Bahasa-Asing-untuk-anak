using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class button : MonoBehaviour {
	public Button a;
	public Button b;
	public Button c;
	// Use this for initialization
	void Start () {
		a = a.GetComponent<Button> ();
		b = b.GetComponent<Button> ();
		c = c.GetComponent<Button> ();
	}
	
	// Update is called once per frame
	public void tekan () {
		a.enabled = false;
		b.enabled = false;
		c.enabled = false;
	}
}
