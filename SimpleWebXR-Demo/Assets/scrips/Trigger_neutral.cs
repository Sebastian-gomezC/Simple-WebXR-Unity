using System;
using UnityEngine;
using UnityEngine.Events;

public class Trigger_neutral : MonoBehaviour
{
    public string tagFilter;

    public UnityEvent onTriggerEnter;
    public UnityEvent onTriggerExit;
    public Transform tester;
    private Vector3 origin_1 ;
    public static bool neutral=false;
    private float t_wait=0;
    private void OnTriggerEnter (Collider other)
    {
        onTriggerEnter.Invoke();
        if(other.name == tester.name){
            neutral=true;
        }


    }

    private void OnTriggerExit (Collider other)
    {
        if (other.tag == tagFilter)
            { 
                onTriggerEnter.Invoke();
                neutral=false;
            }
    }
    void Update()
    {
     if(neutral && (t_wait < 100f ) ){
        origin_1= tester.position;
        tester.position = transform.position - new Vector3(0.0f,0.0f,0.08f) ;
        Quaternion target = Quaternion.Euler(0, 0, 0);
        tester.rotation = Quaternion.Slerp(tester.rotation, target,  1);
        t_wait += Time.deltaTime;
     }
     else if(neutral && (t_wait >= 100f )){
        t_wait=102;
     }
     else{
        t_wait=0;
        
     }
    }
}
