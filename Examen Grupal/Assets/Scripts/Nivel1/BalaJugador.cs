using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaJugador : BalaMover, DañoJugador
{
    public int daño;

    void Start()
    {
        Destroy(gameObject, vida);
    }

    public int DañoPlayer()
    {
        return daño;
    }
}
