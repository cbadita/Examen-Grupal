using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JugadorNivel2 : MonoBehaviour
{
    public float velocidad;
    public Rigidbody rb;
    public float Vertical;
    public int vida;

    private void Update()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.W))
        {
            Vertical = 1f;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            Vertical = 0;
        }


        Vector2 movement = new Vector2(Horizontal, Vertical);

        if (movement.y < 0 && rb.position.y <= 0)
        {
            movement.y = 0;
        }

        rb.velocity = movement * velocidad;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<DañoJugador>() != null)
        {
            CambiarVida(-other.gameObject.GetComponent<DañoJugador>().DañoPlayer());
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level2");
        }
        if (other.gameObject.name == "Menu")
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    void CambiarVida(int valor)
    {
        vida += valor;

        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
