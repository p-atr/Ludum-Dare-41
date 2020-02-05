using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class scenes : MonoBehaviour {
    // Use this for initialization
    public int main;
    public int stealth;
    public int date;
    public int zeitung;
    public int laterne;
    public int lost;
    public int love;
    public int credits;

    void Start()
    {

    }
    public void LoadMain()
    {
        SceneManager.LoadScene(main);
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene(credits);
    }

    public void LoadStealth()
    {
        SceneManager.LoadScene(stealth);
    }

    public void LoadDate()
    {
        SceneManager.LoadScene(date);
    }
    

    public void LoadZeitung()
    {
        SceneManager.LoadScene(zeitung);
    }

    public void LoadLaterne()
    {
        SceneManager.LoadScene(laterne);
    }

    public void LoadLost()
    {
        SceneManager.LoadScene(lost);
    }
    public void LoadLove()
    {
        SceneManager.LoadScene(love);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
