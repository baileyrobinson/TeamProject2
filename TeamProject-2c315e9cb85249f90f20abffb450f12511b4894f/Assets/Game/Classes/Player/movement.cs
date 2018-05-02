using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 10;
    public int startingStamina = 100;                            // The amount of stamina the player starts the game with.
    public float currentStamina;                                   // The current stamina the player has.
    public Slider staminaSlider;
    public GameObject ExitMenu;
    private Vector3 moveDirection = Vector3.zero;
    public float gravity = 100.0F;
    public bool canmove;


    // Use this for initialization
    void Start()
    {
        canmove = true;

        currentStamina = startingStamina;
        
        if (Input.GetKey(KeyCode.Escape))
        {
            Screen.lockCursor = false;
        }
        else
        {
            Screen.lockCursor = true;
        }
    }

    void FixedUpdate()
    {

    }
        // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        if (controller.isGrounded && canmove == true)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift) && currentStamina > 0)
        {

            controller.Move(moveDirection * Time.deltaTime * 1.5f);

            currentStamina -= .5f;
            staminaSlider.value = currentStamina;

         
            if (currentStamina <= 0 && Input.GetKey(KeyCode.LeftShift))
            {
                controller.Move(moveDirection * Time.deltaTime);
            }
        }
        else
        {
            if (currentStamina < startingStamina)
            {
                currentStamina += .25f;
                staminaSlider.value = currentStamina;
            }
        }

        if (Input.GetKey(KeyCode.Tab))
       {
          ExitMenu.SetActive(true);
          Screen.lockCursor = false;

        }
      
    }

    void OnGUI()
    {
        GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 10, 10), "");
    }

}




