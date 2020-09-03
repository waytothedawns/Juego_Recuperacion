using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    int coinsCounter;
    public Text text;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            coinsCounter++;
            text.text = coinsCounter.ToString("0");
        }
    }
    public int CoinsNumber()
    {
        return coinsCounter; 
    }
}
