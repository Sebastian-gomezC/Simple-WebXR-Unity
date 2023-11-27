using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class doorbutton : Interactable

{
    public override void Interac(){
        base.Interac();
        opendoorscript.opening = !opendoorscript.opening;
    }
}
