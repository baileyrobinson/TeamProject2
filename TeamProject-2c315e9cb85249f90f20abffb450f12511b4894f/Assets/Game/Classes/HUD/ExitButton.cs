using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ExitButton : PlayerInventory
{

    public Button exitbutton;
    public GameObject BlackSmithMenu;

    void Start()
    {
        Button btn = exitbutton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //Cursor.visible = false;
        Screen.lockCursor = true;
        BlackSmithMenu.SetActive(false);
    }
}
