using System;
using UnityEngine;
using UnityEngine.Events;

public class Trigger_fase2 : MonoBehaviour
{
    public string tagFilter;

    public UnityEvent onTriggerEnter;
    public UnityEvent onTriggerExit;
    public Transform tester;
    private Vector3 origin_1 ;
    public static bool fase2=false;
    public static bool fase2_tested=false;

    private float t_wait=0;
    private void OnTriggerEnter (Collider other)
    {
        onTriggerEnter.Invoke();
        if(other.name == tester.name){
            fase2=true;
            origin_1= tester.position;
            fase2_tested=true;
           
        }


    }

    private void OnTriggerExit (Collider other)
    {
        if (other.tag == tagFilter)
            { 
                onTriggerEnter.Invoke();
                fase2=false;
            }
    }
void Update()
    {
     if(fase2 && (t_wait < 15f ) ){
        origin_1= tester.position;
        tester.position = transform.position - new Vector3(0.0f,0.0f,0.08f) ;
        Quaternion target = Quaternion.Euler(0, 0, 0);
        tester.rotation = Quaternion.Slerp(tester.rotation, target,  1);
        t_wait += Time.deltaTime;
     }
     else if(fase2 && (t_wait >= 15f )){
        t_wait=16;
     }
     else{
        t_wait=0;
     }
    }
}
