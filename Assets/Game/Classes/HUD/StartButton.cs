using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StartButton : MonoBehaviour {

    public Button Startbutton;

    void Start()
    {
        Button btn = Startbutton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Application.LoadLevel("GameScene");
    }

}
