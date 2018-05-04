using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PortalButton : PlayerInventory
{
    public Button ClosePortalbutton;
    public GameObject Portal1;
    public GameObject Portal2;
    public GameObject Portal3;

    public Text cost;
    public int Cost = 1000;

    public bool Portal1alive = true;
    public bool Portal2alive = true;
    public bool Portal3alive = true;

    // Use this for initialization
    void Start ()
    {
        Button btn = ClosePortalbutton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        cost.text = "Gold: " + Cost;
    }

    void TaskOnClick()
    {
        if (Money >= Cost)
        {

            Destroy(Portal1);
            Portal1alive = false;
            
            if (Portal1alive == false)
            {
                Destroy(Portal2);
                Portal2alive = false;
            }


            if (Portal2alive == false)
            {
                Destroy(Portal3);
                Portal3alive = false;   
            }

            if (Portal1alive == false && Portal2alive == false && Portal3alive == false)
            {
                Application.LoadLevel("WinScreen");
            }
        }
    }
}
