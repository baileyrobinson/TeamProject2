using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PWPlayerPawn : PWPawn {

    Rigidbody rb;
    public float MoveSpeed = 10f;
    public float RotateSpeed = 180f;
    public float MinVelocity = .01f;
    public float speed = 10;
    public int startingStamina = 100;                            // The amount of stamina the player starts the game with.
    public float currentStamina;                                   // The current stamina the player has.
    public Slider staminaSlider;
    public GameObject ExitMenu;

    public virtual void Start()
    {
        IsSpectator = false;

        // Add and Set up Rigid Body
        rb = gameObject.AddComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        rb.constraints = RigidbodyConstraints.FreezePosition;


        Health = StartingHealth;
        Stamina = StartingStamina;

        if (Input.GetKey(KeyCode.Escape))
        {
            Screen.lockCursor = false;
        }
        else
        {
            Screen.lockCursor = true;
        }

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            ExitMenu.SetActive(true);
            Screen.lockCursor = false;
        }
    }

    protected override bool ProcessDamage(Actor Source, float Value, DamageEventInfo EventInfo, Controller Instigator)
    {
        Health -= Value;
        LOG(ActorName + " HP: " + Health);

        if (Health <= 0)
        {
            controller.RequestSpectate();
            //Destroy(gameObject);

        }

        return base.ProcessDamage(Source, Value, EventInfo, Instigator);

    }

    public override void OnUnPossession()
    {
        IgnoresDamage = true;
    }

    public virtual void FixedUpdate()
    {
        if (rb.velocity.magnitude < MinVelocity)
        {
            rb.velocity = Vector3.zero;
        }
    }

    public override void Horizontal(float value)
    {
        if (value != 0)
        {
            //LOG("Pawn-Horizontal (" + value + ")");
            gameObject.transform.Rotate(0, (RotateSpeed * value * Time.fixedDeltaTime), 0);
        }
    }

    public override void Vertical(float value)
    {
        if (value != 0)
        {
            rb.velocity = gameObject.transform.forward * MoveSpeed * value;
        }
        if (Input.GetKey(KeyCode.LeftShift) && currentStamina > 0)
        {
            currentStamina -= .5f;
            staminaSlider.value = currentStamina;
            rb.velocity = gameObject.transform.forward * MoveSpeed * 1.5f;

            // If the player has lost all it's stamina and the death flag hasn't been set yet...
            if (currentStamina <= 0)
            {
                rb.velocity = gameObject.transform.forward * MoveSpeed * value;
            }
        }
        else
        {
            if (Stamina < startingStamina)
            {
                Stamina += .25f;
                staminaSlider.value = currentStamina;
            }
        }
    }

    public override void Fire1(bool value)
    {
        if (value)
        {
           
        }
    }
    void OnGUI()
    {
        GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 10, 10), "");
    }
}

