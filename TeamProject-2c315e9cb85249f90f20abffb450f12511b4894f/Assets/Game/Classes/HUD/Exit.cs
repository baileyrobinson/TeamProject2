using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Exit : MonoBehaviour {

    public Button exitbutton;

    void Start()
    {
        Button btn = exitbutton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Application.LoadLevel("StartScreen");
    }
}
