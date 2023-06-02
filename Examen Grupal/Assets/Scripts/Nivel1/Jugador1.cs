using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugador1 : MonoBehaviour
{
    public int vida;
    public float velocidad;
    public Rigidbody rb;


    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        Vector2 mover = new Vector2(Horizontal, 0);
        rb.velocity = mover * velocidad;
    }

    public void CambioVida(int valor)
    {
        vida += valor;

        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<DañoEnemigo>() != null)
        {
            CambioVida(-other.gameObject.GetComponent<DañoEnemigo>().Daño());
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level1");
        }
    }
}
