using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class play_steps : MonoBehaviour
{
    public static int fase;
    public GameObject fase1;
    public GameObject fase2;
    public GameObject fase3;
    public GameObject fase4;
    public GameObject door_button;
    // Start is called before the first frame update
    void Start()
    {
        fase=0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("fase "+ fase + " pass" );
    }
    public void fase_1(){
        fase=1;
        fase1.SetActive(true);
    }
    public void fase_2(){
        fase1.SetActive(false);
        fase2.SetActive(true);
        fase=2;
        door_button.SetActive(true);
        
    }
    public void fase_3(){
        fase=3;
        fase2.SetActive(false);
        fase3.SetActive(true);
    }
    public void fase_4(){
        fase=4;
    }
}
