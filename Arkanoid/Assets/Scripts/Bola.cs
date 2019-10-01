using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public Vector2 velocidade;
    int contador = 0;
    public GameController controller;

    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(velocidade);
    }

    private void Update()
    {
        if (contador >= 40)
        {
            controller.Ganhou();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bloco")
        {
            contador++;
        }
    }
}
