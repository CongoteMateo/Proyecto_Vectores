using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectInteraction : MonoBehaviour
{
    public Text txtpuntos;
    public int puntos;
    public Transform personaje;
    public float tamanoRandom;

    
    void Start()
    {
        cambiarPos();
        //puntos = 100;        
        txtpuntos.text=puntos.ToString();        
    }

    private void OnMouseDown()
    {
        cambiarPos();
        sumarpuntos();
    }

    void sumarpuntos()
    {
        puntos++;
        //puntos=puntos-10;
        txtpuntos.text=puntos.ToString();
    }

    void cambiarPos()
    {
        transform.position = new Vector3((Random.insideUnitSphere.x*tamanoRandom), transform.position.y, (Random.insideUnitSphere.z*tamanoRandom));
        Vector3 pospersonaje = new Vector3(personaje.position.x, personaje.position.y, personaje.position.z);
        transform.LookAt (pospersonaje);
    } 
}
