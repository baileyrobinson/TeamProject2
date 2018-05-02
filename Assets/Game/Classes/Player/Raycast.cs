using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Raycast : UpgradeButton
{
    public GameObject Blacksmith;
    public GameObject BlackSmithMenu;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(Blacksmith.transform.position, transform.position);
        //Debug.Log(dist);// assuming barnDoor being a gameobject

        var fwd = transform.TransformDirection(Vector3.forward);
        if (Physics.Raycast(transform.position, fwd, 1))
        {
           // Debug.Log("Close enough to press key e");

            if (Input.GetKeyDown(KeyCode.E))
            {
                Screen.lockCursor = false;
                Cursor.visible = true;

                BlackSmithMenu.SetActive(true);
                Debug.Log("I pressed E while aiming at an object!");
            }

        }
    }

}
