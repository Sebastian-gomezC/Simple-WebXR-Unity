using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linkconector : MonoBehaviour
{
    public Transform init;
    public Transform points;
    public Transform final;
    private LineRenderer line;
    private Vector3[] positions = new Vector3[1];
    private int iter = 0;

    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();  
        line.SetPosition(0,init.localPosition) ;
        iter=1;
        foreach (Transform child in points)
        {
         line.SetPosition(iter,child.localPosition) ;
         iter++;
        }

        line.SetPosition(iter,final.localPosition);
        line.useWorldSpace = false;

        line.loop = false;
        line.numCornerVertices = 10;
        line.widthMultiplier = 0.005f;
        }

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(0,init.localPosition) ;
        iter=1;
        foreach (Transform child in points)
        {
         line.SetPosition(iter,child.localPosition) ;
         iter++;
        }

        line.SetPosition(iter,final.localPosition);
        


    }
}
