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
        [SerializeField] GameObject canvasVictory;
        CoinCounter coinCounter;
        private void Start()
        {
            canvasVictory.SetActive(false);
        }
        void OnTriggerEnter2D(Collider2D collider)
        {
            var p = collider.gameObject.GetComponent<PlayerController>();
            coinCounter = p.GetComponent<CoinCounter>();
            
            
            if (p != null && coinCounter.CoinsNumber() >= coinsToWin)
            {
                //Cuando ganas
                var ev = Schedule<PlayerEnteredVictoryZone>();
                ev.victoryZone = this;
                Invoke("LoadNextScene", 2);
                ps.Play();
            }
            else if(p != null && coinCounter.CoinsNumber() < coinsToWin)
            {

                canvasVictory.SetActive(true);
            }
        }

        private void LoadNextScene()
        {
            SceneManager.LoadScene(7);
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                if(coinCounter.CoinsNumber() < coinsToWin)
                {
                    //Desactivar canvas advertencia
                    canvasVictory.SetActive(false);
                }
            }
        }
    }
}