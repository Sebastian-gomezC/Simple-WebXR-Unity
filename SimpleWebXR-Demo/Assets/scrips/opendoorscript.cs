using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoorscript : MonoBehaviour
{
    public GameObject door;
    public static bool opening;
    private Vector3 initialRot;
    void Start(){
        opening=false;
        initialRot = door.transform.localEulerAngles;
    }
    void Update()
    {

        Vector3 currentRot = door.transform.localEulerAngles;
        
        if (opening)
        {
            if ((currentRot.y-initialRot.y)< 90f )
            {
                door.transform.localEulerAngles = Vector3.Lerp(currentRot, new Vector3(currentRot.x,initialRot.y+ 89.9f, currentRot.z), 1f * Time.deltaTime);
            }
        }
        else
        {
            if ((currentRot.y -initialRot.y) > 0f)
            {
                door.transform.localEulerAngles = Vector3.Lerp(currentRot, new Vector3(currentRot.x, initialRot.y, currentRot.z), 1f * Time.deltaTime);               
            }
        }

    }


    public void ToggleDoor()
    {
        opening = !opening;
    }
}


