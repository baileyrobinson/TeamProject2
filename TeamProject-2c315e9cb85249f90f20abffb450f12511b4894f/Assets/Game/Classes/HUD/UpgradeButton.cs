using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UpgradeButton : PlayerInventory
{

    public Button upgradebutton;
    public Text cost;
    public int Cost = 100;

    void Start()
    {
        Button btn = upgradebutton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        cost.text = "Gold: " + Cost + System.Environment.NewLine + "Material: " + Cost.ToString();
    }

    void TaskOnClick()
    {
       
        if (Money >= Cost && Materials >= Cost)
        {
            WeaponLevel +=1;
            Debug.Log("You have clicked the button!");

            Materials -= Cost;
            Money -= Cost;

            Cost += 50;
        }
        cost.text = "Gold: " + Cost + System.Environment.NewLine + "Material: " + Cost.ToString();

    }
}
