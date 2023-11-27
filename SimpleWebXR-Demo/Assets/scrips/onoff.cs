using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onoff: MonoBehaviour
{
    public Material verde;
    public Material rojo;
    public GameObject interrump ;
    public GameObject sound;
    public GameObject sparks;
    public static bool On;
    public static bool fail;
    void Start(){
        int prob = Random.Range(0,3);
        if (prob==0 || prob == 1 ){
            fail = false;
            sparks.SetActive(false);
        }
        else{
            fail=true;
            sparks.SetActive(true);
        }
        On=true;
        Debug.Log("fail+++++++++++++= " + fail);
    }
    void Update()
    {

        Vector3 currentRot = interrump.transform.localEulerAngles;
        
        if (!On) 
        {
            if (currentRot.z< 360f )
            {
                interrump.transform.localEulerAngles = Vector3.Lerp(currentRot, new Vector3(currentRot.x,currentRot.y, 359.9f), 1f * Time.deltaTime);    
            }
            if (!fail)
            {
                verde.EnableKeyword("_EMISSION");
                rojo.DisableKeyword("_EMISSION");
                sound.SetActive(false);

            }
            else
            {
                verde.DisableKeyword("_EMISSION");
                rojo.EnableKeyword("_EMISSION");
            }
            
            

        }
        else
        {
            if (currentRot.z > 270f)
            {
                interrump.transform.localEulerAngles = Vector3.Lerp(currentRot, new Vector3(currentRot.x, currentRot.y, 270f), 1f * Time.deltaTime);               
            }
            
            verde.DisableKeyword("_EMISSION");
            rojo.EnableKeyword("_EMISSION");
        }

    }


    public void ToggleOnOff()
    {
        On = !On;
    }
}
