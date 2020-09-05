using System.Collections;
using System.Collections.Generic;
using Platformer.Gameplay;
using UnityEngine;
using static Platformer.Core.Simulation;
using UnityEngine.SceneManagement;

namespace Platformer.Mechanics
{
    public class DeathZone : MonoBehaviour
    {
        public enum Nivel { Nivel_1, Nivel_2 };
        public Nivel nivel;
        void OnTriggerEnter2D(Collider2D collider)
        {

            var p = collider.gameObject.GetComponent<PlayerController>();
            switch (nivel)
            {
                case Nivel.Nivel_1:
                    if (p != null)
                    {
                        var ev = Schedule<PlayerEnteredDeathZone>();
                        ev.deathzone = this;
                        SceneManager.LoadScene(8);
                    }
                    break;
                case Nivel.Nivel_2:
                    if (p != null)
                    {
                        var ev = Schedule<PlayerEnteredDeathZone>();
                        ev.deathzone = this;
                        SceneManager.LoadScene(10);
                    }
                    break;
               
            }
           
        }
    }
}