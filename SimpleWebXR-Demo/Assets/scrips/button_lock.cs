using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class button_lock : MonoBehaviour
{
    public Button button;
    void Update()
    {
        if (onoff.On)
        {
            button.interactable=false;
        }
        else 
        {
            button.interactable=true;
        }
       
    }
    
}
