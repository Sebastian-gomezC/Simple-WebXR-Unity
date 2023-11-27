using System;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    public string tagFilter;

    public UnityEvent onTriggerEnter;
    public UnityEvent onTriggerExit;
    public Transform tester;
    private Vector3 origin_1 ;
    public bool fase2=false;
    void Start(){
        Debug.Log("coll " );
    }
    private void OnTriggerEnter (Collider other)
    {
        onTriggerEnter.Invoke();
        if(other.name == tester.name){
            fase2=true;
           origin_1= tester.position;
           
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
     if(fase2){
        Quaternion target = Quaternion.Euler(90, 0, 0);
        tester.position = origin_1;
        tester.rotation = Quaternion.Slerp(tester.rotation, target,  0);

     }
    }
}
