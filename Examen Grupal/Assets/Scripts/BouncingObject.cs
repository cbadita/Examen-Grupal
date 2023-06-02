using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingObject : MonoBehaviour, IGameObjectObserver
{
    private float speed = 5f;
    private Vector3 direction;

    private void Start()
    {
        GameController.Instance.AddObserver(this);
        direction = GetRandomDirection();
    }

    private void OnDestroy()
    {
        GameController.Instance.RemoveObserver(this);
    }

    private void Update()
    {
        if (GameController.Instance.interfaceVisible)
        {
            // Si la interfaz est� visible, el objeto se detiene
            return;
        }

        // Mueve el objeto en la direcci�n determinada
        transform.Translate(direction * speed * Time.deltaTime);

        // Comprueba si el objeto ha alcanzado los l�mites de la pantalla y cambia de direcci�n
        if (transform.position.x < -10f ||  transform.position.x > 10f)
        {
            direction.x *= -1;
        }
        if (transform.position.y < -5f ||  transform.position.y > 5f)
        {
            direction.y *= -1;
        }
    }

    public void OnNotify()
    {
        // Cambia la direcci�n del objeto cuando recibe una notificaci�n
        direction = GetRandomDirection();
    }

    private Vector3 GetRandomDirection()
    {
        // Genera una direcci�n de movimiento aleatoria
        float randomX = Random.Range(-1f, 1f);
        float randomY = Random.Range(-1f, 1f);
        return new Vector3(randomX, randomY, 0f).normalized;
    }
}
