using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void BotonPLAY()          // Carga el Gameplay
    {
        SceneManager.LoadScene(1);
    }

    public void BotonOPTIONS()       // Abre las Opciones
    {
        SceneManager.LoadScene(2);
    }

    public void BotonMENU()         // Carga el Menu
    {
        SceneManager.LoadScene(0);
    }

    public void BotonEXIT()          // Cierra la ventana
    {

        Application.Quit();

    }
}