using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PWPlayerController : PlayerController {

    public bool IgnoreHudError = false;
    public GameObject ExitPanel;

    // This is how you create a list.Notice how the type
    //is specified in the angle brackets (< >).
    public List<GameObject> Pawns = new List<GameObject>();

    public void NextSpawnPrefab()
    {


    }

    public void PreviouseSpawnPrefab()
    {


    }

    // Use this for initialization
    protected override void Start()
    {
        base.Start();
        LogInputStateInfo = false;

    }

    protected override void UpdateHUD()
    {
        if (!HUD && !PossesedPawn)
        {
            if (!IgnoreHudError)
            {
                LOG_ERROR("No Hud or Pawn!");
            }
            return;
        }

        HUD hud = HUD.GetComponent<HUD>();
        if (!hud)
        {
            if (!IgnoreHudError)
            {
                LOG_ERROR("No Hud Class found");
            }
            return;
        }

        PWPawn pawn = (PWPawn)PossesedPawn;
        if (!pawn)
        {
            if (!IgnoreHudError)
            {
                LOG_ERROR("Controller doesn't have a PWPawn");
            }
            return;
        }

        if (PossesedPawn.IsSpectator)
        {

        }
        else
        {

        }
    }

    public override void Horizontal(float value)
    {
        PWPawn CP = (PWPawn)PossesedPawn;
        if (CP)
        {
            CP.Horizontal(value);
        }
    }

    public override void Vertical(float value)
    {
        //LOG(GetPossesedPawn().ToString()); 
        PWPawn CP = (PWPawn)PossesedPawn;
        if (CP)
        {
            CP.Vertical(value);
        }
    }

    public override void Fire1(bool value)
    {
        PWPawn CP = (PWPawn)PossesedPawn;
        if (CP)
        {
            CP.Fire1(value);
        }
    }

}
