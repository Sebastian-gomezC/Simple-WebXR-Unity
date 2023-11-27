using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramov : MonoBehaviour
{
    public GameObject fpscamara;
    //public float Hspeed;
    //public float Vspeed;

    //float h;
    //float v;
    private Transform camera;
    // Start is called before the first frame update
    void Start()
    {
        /*
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible =true;
        */
        camera =transform.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        
        /*
        h = Hspeed*Input.GetAxis("Mouse X");
        v = Vspeed*Input.GetAxis("Mouse Y");
        transform.Rotate(0,h,0);
        fpscamara.transform.Rotate(-v,0,0);
        */
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(0,0,0.01f);
        }else{
            if (Input.GetKey(KeyCode.S)){
                transform.Translate(0,0,-0.01f);
            }else{
                if (Input.GetKey(KeyCode.D)){
                transform.Translate(0.01f,0,0);
                }else{
                    if (Input.GetKey(KeyCode.A)){
                    transform.Translate(-0.01f,0,0);
                }
                }
            }
        }

        Debug.DrawRay(camera.position,camera.forward*3f,Color.red);

        if(Input.GetButtonDown("activate")){
            RaycastHit hit;
            if(Physics.Raycast(camera.position,camera.forward,out hit, 3f,LayerMask.GetMask("bottoms"))){
                hit.transform.GetComponent<Interactable>().Interac();
                Debug.Log(hit.transform.name);
            }
        }
    }
}
