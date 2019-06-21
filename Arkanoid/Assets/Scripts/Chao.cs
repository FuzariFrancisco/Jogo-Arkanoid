using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chao : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0;
    }
}
