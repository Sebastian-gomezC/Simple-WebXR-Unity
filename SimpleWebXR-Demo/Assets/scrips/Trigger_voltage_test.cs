using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Trigger_voltage_test : MonoBehaviour
{
    public string tagFilter;

    public UnityEvent onTriggerEnter;
    public UnityEvent onTriggerExit;
    public Text textBox;
    public float t = 0;
    void Update(){
        t += Time.deltaTime;
        // Debug.Log("render "+  Math.Round(EvaluarExpresion(t)));
    }
    static double EvaluarExpresion(double x)
    {
        double resultado = 111 * (x / (1 + x)) + 0.5*Math.Exp(Math.Cos(10 * x));
        return resultado;
    }
    private void OnTriggerEnter (Collider other)
    {
        
        onTriggerEnter.Invoke();

    }

    private void OnTriggerExit (Collider other)
    {
        if (other.tag == tagFilter)
            { 
             onTriggerEnter.Invoke();
            }
    }
}
