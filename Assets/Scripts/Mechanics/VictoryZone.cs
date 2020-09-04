using Platformer.Gameplay;
using UnityEngine;
using static Platformer.Core.Simulation;
using UnityEngine.SceneManagement;

namespace Platformer.Mechanics
{
    /// <summary>
    /// Marks a trigger as a VictoryZone, usually used to end the current game level.
    /// </summary>
    public class VictoryZone : MonoBehaviour
    {
        [SerializeField] int coinsToWin;
        [SerializeField] ParticleSystem ps;
        void OnTriggerEnter2D(Collider2D collider)
        {
            var p = collider.gameObject.GetComponent<PlayerController>();
            CoinCounter coinCounter;
            coinCounter = p.GetComponent<CoinCounter>();
            
            
            if (p != null && coinCounter.CoinsNumber() >= coinsToWin)
            {
                //Cuando ganas
                SceneManager.LoadScene(6);
                var ev = Schedule<PlayerEnteredVictoryZone>();
                ev.victoryZone = this;
                ps.Play();
            }else if(p != null && coinCounter.CoinsNumber() < coinsToWin)
            {
                
                //Aquí se ejecuta el codigo cuando el player esta en la zona de la victoria pero no tiene las monedas suficientes
            }
        }
    }
}