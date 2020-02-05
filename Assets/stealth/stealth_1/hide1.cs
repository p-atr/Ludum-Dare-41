using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hide1 : MonoBehaviour
{
    public GameObject player;
    public GameObject hidebank;
    public GameObject canvas;


    public void UnHide()
    {
        player.SetActive(true);
        hidebank.SetActive(false);
        canvas.SetActive(false);
    }

}
