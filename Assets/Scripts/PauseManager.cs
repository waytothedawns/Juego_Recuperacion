using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    bool isPaused;
    [SerializeField]GameObject canvasPause;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }
    }
    void Pause()
    {
        isPaused = !isPaused;
        canvasPause.SetActive(isPaused);
        Time.timeScale = 0;
    }
}
