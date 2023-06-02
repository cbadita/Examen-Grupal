using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tiempo : MonoBehaviour
{
    public float tiempo;
    public float tiempoMaximo;
    public TextMeshProUGUI texto;

    private void Update()
    {
        texto.text = "Tiempo: " + tiempo.ToString("0") + "/" + tiempoMaximo;

        if(tiempo < tiempoMaximo)
        tiempo += Time.deltaTime;

        if (tiempo >= tiempoMaximo)
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
