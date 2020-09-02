using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void BotonPLAY()          // Carga el Gameplay
    {
        SceneManager.LoadScene(0);
    }

    public void BotonOPTIONS()       // Abre las Opciones
    {
        SceneManager.LoadScene(4);
    }

    public void BotonMENU()         // Carga el Menu
    {
        SceneManager.LoadScene(1);
    }

    public void BotonCREDITOS()
    {
        SceneManager.LoadScene(3);
    }
    public void BotonCONTROLES()
    {
        SceneManager.LoadScene(2);
    }

    public void BotonLEVELSELECT()
    {
        SceneManager.LoadScene(5);
    }

    public void BotonEXIT()          // Cierra la ventana
    {

        Application.Quit();

    }
}