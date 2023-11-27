using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class voltage_test : MonoBehaviour
{
    public string tagFilter;
    public TextMesh textBox;
    public GameObject perder;
    public GameObject ganar;
    public float t = 0;
    void Update(){
        t += Time.deltaTime;
        if (Trigger_neutral.neutral && (Trigger_fase1.fase1 || Trigger_fase2.fase2 )){
            if(onoff.fail ){
                textBox.text = EvaluarExpresion(t).ToString("0");
                perder.SetActive(true);
                
            }else if(!onoff.fail && onoff.On){
                textBox.text = EvaluarExpresion(t).ToString("0");
                perder.SetActive(true);
            }else{
                textBox.text = "000";
                if(Trigger_fase1.fase1_tested && Trigger_fase2.fase2_tested  ){
                    ganar.SetActive(true);
                }
                
            }

            
        }
        else{
            textBox.text = "000";
        }
        
        // Debug.Log("render "+  Math.Round(EvaluarExpresion(t)));
    }
    static double EvaluarExpresion(double x)
    {
        double resultado = 111 * (x / (1 + x)) + 0.5*Math.Exp(Math.Cos(10 * x));
        return resultado;
    }
    
}
