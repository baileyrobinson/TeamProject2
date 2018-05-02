using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PWPawn : Pawn {

    public string PawnPrefabName;

    public float StartingHealth = 100.0f;
    public float StartingStamina = 100.0f;

    public float Health = 100.0f;
    public float Stamina = 100.0f;

    public virtual void Horizontal(float value)
    {

    }

    public virtual void Vertical(float value)
    {

    }

    public virtual void Fire1(bool value)
    {

    }
}
