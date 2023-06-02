using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BalaMover : MonoBehaviour
{
    [SerializeField] protected Rigidbody rigid;
    [SerializeField] protected float velocidad;
    [SerializeField] protected float vida;

    protected virtual void Update()
    {
        rigid.velocity = transform.up * velocidad;
    }
}
