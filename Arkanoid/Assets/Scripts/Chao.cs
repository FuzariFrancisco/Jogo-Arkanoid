using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chao : MonoBehaviour
{
    public GameController controller;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        controller.Perdeu();
    }
}
