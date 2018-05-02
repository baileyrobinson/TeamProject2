using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponUpgrades : MonoBehaviour {
    public int MaterialCost = 40;
    public int MoneyCost = 100;
    public int MaterialIncrement = 20;
    public int MoneyIncrement = 50;

    void WeaponUpgrade()
    {
        PlayerInventory.Materials -= MaterialCost;
        PlayerInventory.Money -= MoneyCost;
        PlayerInventory.WeaponLevel++;
        IncrementCost();
    }

    void IncrementCost()
    {
        MaterialCost += MaterialIncrement;
        MoneyCost += MoneyIncrement;
    }
}
