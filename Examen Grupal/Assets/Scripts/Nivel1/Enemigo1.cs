using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo1 : MonoBehaviour, Da�oEnemigo
{
    public GameObject jugador;
    public float velocidad;
    public int da�o;
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

    public int Da�o()
    {
        return da�o;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Da�oJugador>() != null)
        {
            CambiarVida(-other.gameObject.GetComponent<Da�oJugador>().Da�oPlayer());
            Destroy(other.gameObject);
        }
    }
}
