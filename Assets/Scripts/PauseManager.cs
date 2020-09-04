using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    bool isPaused;
    bool isOptions;
    bool isControls;
    [SerializeField]GameObject canvasPause;
    [SerializeField] GameObject canvasOptions;
    [SerializeField] GameObject canvasControls;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }

    }
    public void BotonOPTIONS()
    {
        Options();
    }
    public void BotonSALIR()
    {
        Exit();
    }
    public void BotonSALIR2()
    {
        Exit2();
    }
    public void BotonCONTROLES() {
        Controles();
    }

    void Pause()
    {
        isPaused = !isPaused;
        canvasPause.SetActive(isPaused);
        Time.timeScale = 0;
    }

    void Options()
    {
        isOptions = !isOptions;
        canvasOptions.SetActive(isOptions);
    }
    void Exit()
    {
        canvasOptions.SetActive(false);
    }
    void Controles() 
    {
        isControls = !isControls;
        canvasControls.SetActive(isControls);
    }
    void Exit2()
    {
        canvasControls.SetActive(false);
    }
}
