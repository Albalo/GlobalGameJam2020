using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanzamiento : MonoBehaviour
{
    //Añadir Script al objeto que se va a lanzar
    //Este script solo contempla el hecho que el objeto avance y gire al mismo tiempo

    public float velocidad = 5f;    //velocidad para avanzar y girar

    public void Update()
    {
        Movimiento();   //Se manda a llamr a la función movimiento
    }

    public void Movimiento()
    {
        Vector3 direccion = new Vector3(0, 0, 1);   //Se hace un nuevo vector que "indicará" la dirección hacia donde avanza
        transform.position = transform.position + direccion * velocidad * Time.deltaTime;   //Se asigna a una nueva posición en la dirección anterior y se multiplica por la velocidad 
        transform.Rotate(0f, 0f, -velocidad);   //Se rota con la velocidad inicial en uno de los tres ejes
    }
}
