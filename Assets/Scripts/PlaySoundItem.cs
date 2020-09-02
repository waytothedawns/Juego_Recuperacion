using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(AudioSource))]
public class PlaySoundItem : MonoBehaviour
{    
    AudioSource audioBass;
    [SerializeField] float timeFadeAudio;
    SpriteRenderer spriteRenderer;
    private void Awake()
    {
        audioBass = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        audioBass.volume = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            audioBass.DOFade(1, timeFadeAudio);
            spriteRenderer.enabled = false;
        }
    }
}
