using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distance : MonoBehaviour
{    
    // Start is called before the first frame update
    public GameObject m_GotHitScreen;
    public Transform t1;
    public Transform t2;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        if(Vector3.Distance(t1.position,t2.position) < 2)
        {
        var color = m_GotHitScreen.GetComponent<UnityEngine.UI.Image>().color;
        color.a+= 0.2f;
        m_GotHitScreen.GetComponent<UnityEngine.UI.Image>().color=color;
        }
        Debug.Log(Vector3.Distance(t1.position,t2.position));
        
        /*
        if(Vector3.Distance(t1.position,t2.position) > 1){
        var color = m_GotHitScreen.GetComponent<UnityEngine.UI.Image>().color;
        color.a-= 0.07f;
        m_GotHitScreen.GetComponent<UnityEngine.UI.Image>().color=color;
        }
        */
    }
}