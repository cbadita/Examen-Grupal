using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo1 : MonoBehaviour, DañoEnemigo
{
    public GameObject jugador;
    public float velocidad;
    public int daño;
    public int vida;

    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (jugador != null)
        {
            Vector3 direccion = jugador.transform.position - transform.position;
            direccion.Normalize();

            transform.position += direccion * velocidad * Time.deltaTime;
        }
    }

    public void CambiarVida(int valor)
    {
        vida += valor;

        if(vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    public int Daño()
    {
        return daño;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<DañoJugador>() != null)
        {
            CambiarVida(-other.gameObject.GetComponent<DañoJugador>().DañoPlayer());
            Destroy(other.gameObject);
        }
    }
}
