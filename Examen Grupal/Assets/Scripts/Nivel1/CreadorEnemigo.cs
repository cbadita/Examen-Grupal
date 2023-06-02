using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorEnemigo : MonoBehaviour
{
    public float time;
    public float maxTime;

    [SerializeField] private GameObject enemigo;
    [SerializeField] private GameObject creador;

    public event Action<GameObject> generar;
    public static CreadorEnemigo Instanciador { get; private set; }


    private void Awake()
    {
        if (Instanciador == null)
        {
            Instanciador = this;
        }
    }


    void Update()
    {
        time += Time.deltaTime;

        if (time > maxTime)
        {
            time = 0;
            creador.SetActive(true);
            GameObject enemigoObjeto = Instantiate(enemigo, creador.transform.position, creador.transform.rotation);
            generar?.Invoke(enemigoObjeto);
            creador.SetActive(false);
        }
    }
}
