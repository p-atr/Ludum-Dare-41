using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bank : MonoBehaviour {
    public GameObject player;
    public GameObject hidebank;
    public int delay;
    private float next;
    public bool hidden = false;

    private void Start()
    {
        next = Time.time;
    }
    public void Hide()
    {
        hidden = true;
        player.SetActive(false);
        hidebank.SetActive(true);
        next = Time.time + delay;
    }

    public void UnHide()
    {
        hidden = false;
        player.SetActive(true);
        hidebank.SetActive(false);
    }
    private void Update()
    {
        if (hidden)
        {
            if (Time.time > next)
            {
                UnHide();
            }
        }
    }
    void OnTriggerStay2D()
    {
        if (Input.GetKeyDown("e"))
        {
            Hide();
        }
    }
}
