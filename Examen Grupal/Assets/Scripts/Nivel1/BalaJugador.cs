using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaJugador : BalaMover, Da�oJugador
{
    public int da�o;

    void Start()
    {
        Destroy(gameObject, vida);
    }

    public int Da�oPlayer()
    {
        return da�o;
    }
}
