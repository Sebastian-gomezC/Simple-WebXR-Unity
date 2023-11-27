using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onoffbutton : Interactable

{
    public override void Interac(){
        base.Interac();
        onoff.On = !onoff.On;
    }
}
