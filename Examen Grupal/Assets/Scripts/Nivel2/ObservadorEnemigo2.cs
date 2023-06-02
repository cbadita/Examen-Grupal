using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObservadorEnemigo2 : MonoBehaviour
{
    private void OnEnable()
    {
        CreadorEnemigoNivel2.Instanciador.Encendido += CambiarColor;
    }

    private void OnDisable()
    {
        CreadorEnemigoNivel2.Instanciador.Encendido -= CambiarColor;
    }

    public void CambiarColor(GameObject objeto)
    {
        objeto.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
