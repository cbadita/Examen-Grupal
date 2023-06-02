using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2 : MonoBehaviour, Da�oJugador
{
    public GameObject bala;
    public Transform disparo;

    public float tiempo;
    public float tiempoMaximo;

    public int da�o;

    void Update()
    {
        tiempo += Time.deltaTime;

        if (tiempo > tiempoMaximo)
        {
            tiempo = 0;
            Instantiate(bala, disparo.position, disparo.rotation);
        }
    }

    public int Da�oPlayer()
    {
        return da�o;
    }
}
