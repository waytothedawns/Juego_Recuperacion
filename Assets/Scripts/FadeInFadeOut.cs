using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class FadeInFadeOut : MonoBehaviour
{

    // the image you want to fade, assign in inspector
    [SerializeField] CanvasGroup canvasGroup;
    [SerializeField] float timeFade = 1.5f;
    [SerializeField] string nameNextScene;
    [SerializeField] AudioSource audio;

    private void Start()
    {
        FadeIn();
    }

    public void FadeIn()
    {
        canvasGroup.DOFade(1, timeFade).OnComplete(() => FadeOut());
    }
    public void FadeOut()
    {
        canvasGroup.DOFade(0, timeFade).OnComplete(() => LoadScene());
    }
    void LoadScene()
    {
        SceneManager.LoadScene(nameNextScene);
    }

}
