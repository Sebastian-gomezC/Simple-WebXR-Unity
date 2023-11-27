using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform objetoAseguir;
    public float velocidadSeguimiento = 5.0f;
    public static Vector3 distanceorg ;
    public float tolerancia = 0.1f; 
    // Start is called before the first frame update
    
    void Start(){
        distanceorg = objetoAseguir.position - transform.position;
    }
    void Update()
    {
        // Calcula la dirección hacia el objeto a seguir
        Vector3 direccion = objetoAseguir.position - transform.position-distanceorg;

        if (Mathf.Abs(direccion.magnitude) >= tolerancia)
        {
        // Calcula la distancia actual entre los objetos
        float distanciaActual = direccion.magnitude;

        // Si la distancia actual es mayor que la distancia deseada, mueve el objeto hacia el objetivo

        Vector3 movimiento = direccion.normalized * velocidadSeguimiento * Time.deltaTime;
        transform.Translate(movimiento);
        }

        
    }
}
