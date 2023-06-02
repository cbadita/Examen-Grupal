using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObservadorEnemigo1 : MonoBehaviour
{
    private void OnEnable()
    {
        CreadorEnemigo.Instanciador.generar += Change;
    }

    private void OnDisable()
    {
        CreadorEnemigo.Instanciador.generar -= Change;
    }

    public void Change(GameObject objetoGenerado)
    {
        objetoGenerado.GetComponent<Transform>().localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
}
