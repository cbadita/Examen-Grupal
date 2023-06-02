using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class DisparoJugador : MonoBehaviour
{
    public GameObject bala;
    public GameObject disparo;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bala, disparo.transform.position, disparo.transform.rotation);
        }
    }
}
