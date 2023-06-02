using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;
using UnityEngine.UIElements;

public class CreadorEnemigoNivel2 : MonoBehaviour
{
    public GameObject[] posiciones;
    public GameObject enemigo; 
    public GameObject creador;
    public float tiempo;
    public float tiempoMaximo;


    public event Action<GameObject> Encendido;
    public static CreadorEnemigoNivel2 Instanciador { get; private set; }

    private void Awake()
    {
        if (Instanciador == null)
        {
            Instanciador = this;
        }
    }

    private void Start()
    {
        creador.SetActive(true);

        for (int i = 0; i < posiciones.Length; i++)
        {
            GameObject enemigoCreado = Instantiate(enemigo, posiciones[i].transform.position, posiciones[i].transform.rotation);
            Encendido?.Invoke(enemigoCreado);
        }
    }
}
