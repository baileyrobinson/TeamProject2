using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Continue : MonoBehaviour {

    public Button Continuebutton;

    void Start()
    {
        Button btn = Continuebutton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Application.LoadLevel("GameScene");
    }
}
