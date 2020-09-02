using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transitioner : MonoBehaviour
{
    [SerializeField] Image[] images;

    public void TransIn_FillSimple()
    {
        for (int i = 0; i < images.Length; i++)
        {
            images[i].DOFillAmount(0f, 1f);
        }
    }

    public void TransOut_FillSimple()
    {
        for (int i = 0; i < images.Length; i++)
        {
            images[i].DOFillAmount(1f, 1f);
        }
    }

    public void TransIn_FillDelay()
    {
        for (int i = 0; i < images.Length; i++)
        {
            DOTween.Sequence().Insert(i * 0.25f,
                images[i].DOFillAmount(0f, 1f));
        }
    }

    public void TransOut_FillDelay()
    {
        for (int i = 0; i < images.Length; i++)
        {
            DOTween.Sequence().Insert((images.Length - i) * 0.25f,
                images[i].DOFillAmount(1f, 1f));
        }
    }
}
