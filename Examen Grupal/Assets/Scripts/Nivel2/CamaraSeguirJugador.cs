using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CamaraSeguirJugador : MonoBehaviour
{
    public Transform jugador;
    public float sensibilidad;
    public Vector3 offset;

    void Update()
    {
        if (jugador != null)
        {
            Vector3 posicion = new Vector3(transform.position.x, jugador.position.y + offset.y, transform.position.z);
            Vector3 sensi = Vector3.Lerp(transform.position, posicion, sensibilidad);
            transform.position = sensi;
        }
    }
}
