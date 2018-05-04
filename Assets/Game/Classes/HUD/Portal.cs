using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Portal : Raycast
{

    public Button Portalbutton;
    public GameObject PortalMenu;

    // Use this for initialization
    void Start ()
    {
        Button btn = Portalbutton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }


    void TaskOnClick()
    {
        
        Screen.lockCursor = false;
        Cursor.visible = true;

        PortalMenu.SetActive(true);
        Debug.Log("I pressed E while aiming at an object!");
    }
}
