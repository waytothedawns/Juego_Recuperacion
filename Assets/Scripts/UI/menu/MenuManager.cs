using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void BotonPLAY()          // Carga el Gameplay
    {
        SceneManager.LoadScene(2);
    }
    public void BotonPLAY2()          // Carga el Gameplay
    {
        SceneManager.LoadScene(9);
    }

    public void BotonOPTIONS()       // Abre las Opciones
    {
        SceneManager.LoadScene(5);
    }

    public void BotonMENU()         // Carga el Menu
    {
        SceneManager.LoadScene(1);
    }

    public void BotonCREDITOS()
    {
        SceneManager.LoadScene(4);
    }
    public void BotonCONTROLES()
    {
        SceneManager.LoadScene(3);
    }

    public void BotonLEVELSELECT()
    {
        SceneManager.LoadScene(6);
    }

    public void BotonEXIT()          // Cierra la ventana
    {

        Application.Quit();

    }
}