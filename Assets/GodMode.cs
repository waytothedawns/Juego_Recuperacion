using Platformer.Mechanics;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GodMode : MonoBehaviour
{
    PlayerController playerController;
    bool activeGod = false;
    [SerializeField] float jumpForceGodMode = 15f;
    [SerializeField] GameObject canvasStage;
    [Header("Nombre de las escenas para el cambio de Stage")]
    public string nameScene1;
    public string nameScene2;
    private void Awake()
    {
        playerController = GetComponent<PlayerController>();
        canvasStage.SetActive(false);
    }
    private void Update()
    {
       // IsGodMode();
        if (IsGodMode())
        {
            playerController.GodMode(jumpForceGodMode);
            gameObject.tag = "Untagged";
            canvasStage.SetActive(true);
        }
        else
        {
            gameObject.tag = "Player";
            canvasStage.SetActive(false);
        }
    }
    bool IsGodMode()
    {
        if (Input.GetKeyDown(KeyCode.F10))
        {
            activeGod =! activeGod;
            print("God Mode is: " + activeGod);
        }
        return activeGod;
    }
    public void ChangeToScene1()
    {
        if(nameScene1 == null)
        {
            System.Diagnostics.Debug.Fail("Falta introducir el nombre de la ESCENA 1");
        }
        SceneManager.LoadScene(nameScene1);
    }
    public void ChangeToScene2()
    {
        SceneManager.LoadScene(nameScene2);
        if (nameScene2 == null)
        {
            System.Diagnostics.Debug.Fail("Falta introducir el nombre de la ESCENA 2");
        }
    }
}
