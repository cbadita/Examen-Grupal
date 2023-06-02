using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemigo : BalaMover, DañoJugador
{
    public int daño;

    private void Start()
    {
        Destroy(gameObject, vida);
    }

    public int DañoPlayer()
    {
        return daño;
    }
}
