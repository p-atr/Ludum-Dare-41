using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide : MonoBehaviour {
    public GameObject dude;
    public GameObject hideasset;
    public GameObject bt1;
    public GameObject bt2;
    public GameObject bt3;
    public GameObject bt4;
    public GameObject hidebtn;
    public GameObject unhidebtn;
	public caught c;
	// Use this for initialization
	void Start () {
		
	}
    public void Hide()
    {
		c.hidden = true;
        dude.SetActive(false);
        hideasset.SetActive(true);
        bt1.SetActive(false);
        bt2.SetActive(false);
        bt3.SetActive(false);
        bt4.SetActive(false);
        hidebtn.SetActive(false);
        unhidebtn.SetActive(true);
    }
    public void UnHide()
    {	
		c.hidden = false;
        dude.SetActive(true);
        hideasset.SetActive(false);
        bt1.SetActive(true);
        bt2.SetActive(true);
        bt3.SetActive(true);
        bt4.SetActive(true);
        hidebtn.SetActive(true);
        unhidebtn.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
	}
}
