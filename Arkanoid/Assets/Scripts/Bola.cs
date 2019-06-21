using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public Vector2 velocidade;

    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(velocidade);
    }
}
