using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject painelInicio, painelPerdeu, painelGanhou;

    void Start()
    {
        painelInicio.SetActive(true);
        Time.timeScale = 0;
    }

    public void Comecou()
    {
        painelInicio.SetActive(false);
        Time.timeScale = 1;
    }

    public void Perdeu()
    {
        painelPerdeu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Ganhou()
    {
        painelGanhou.SetActive(true);
        Time.timeScale = 0;
    }

    public void CarregaCena()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void FechaJogo()
    {
        Application.Quit();
    }
}
