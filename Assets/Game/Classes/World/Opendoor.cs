using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opendoor : MonoBehaviour {

    public bool LowerDoor;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        LowerDoor = false;
        float FinalHeight = 127f;

       Vector3 FinalPosition = new Vector3(transform.position.x, FinalHeight, transform.position.z);

        if (LowerDoor)
        transform.position = Vector3.Lerp(transform.position, FinalPosition, Time.deltaTime);
    }
}
