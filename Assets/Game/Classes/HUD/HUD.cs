using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public Image healthBar;
    float maxhealth = 100;
    public float health;

    public Image staminaBar;
    float maxstamina = 100;
    public float stamina;

    void Start()
    {
        health = maxhealth;
        SetHealthBar();
        stamina = maxstamina;
        SetstaminaBar();
    }

    public void SetHealthBar()
    {
        float my_health = health / maxhealth;
        healthBar.transform.localScale = new Vector3(Mathf.Clamp(my_health, 0f, 1f), healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }

    public void SetstaminaBar()
    {
        float my_stamina = stamina / maxstamina;
        staminaBar.transform.localScale = new Vector3(Mathf.Clamp(my_stamina, 0f, 1f), staminaBar.transform.localScale.y, staminaBar.transform.localScale.z);
    }
}
 