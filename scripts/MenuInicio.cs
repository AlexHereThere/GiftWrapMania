using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicio : MonoBehaviour
{
    public void Comenzar()
    {
        SceneManager.LoadScene(1);
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void Creditos()
    {
        SceneManager.LoadScene(3);
    }

    public void SalirCreditos()
    {
        SceneManager.LoadScene(2);
    }
}