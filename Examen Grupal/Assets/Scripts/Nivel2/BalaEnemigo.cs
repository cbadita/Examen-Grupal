using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemigo : BalaMover, Da�oJugador
{
    public int da�o;

    private void Start()
    {
        Destroy(gameObject, vida);
    }

    public int Da�oPlayer()
    {
        return da�o;
    }
}
