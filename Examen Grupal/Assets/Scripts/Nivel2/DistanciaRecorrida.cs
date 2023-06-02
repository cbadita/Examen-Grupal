using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DistanciaRecorrida : MonoBehaviour
{
    public Transform jugador;
    public TextMeshProUGUI texto;
    private Vector3 position;

    private void Start()
    {
        position = new Vector3(0, jugador.position.y, 0);
    }

    private void Update()
    {
        
        float distance = Vector3.Distance(position, new Vector3(0, jugador.position.y, 0));

        texto.text = "Distancia: " + distance.ToString("F2");
    }
}
