using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer.Gameplay;
using DG.Tweening;

namespace Platformer.Mechanics { 
[RequireComponent(typeof(AudioSource))]

public class PlaySoundItem : MonoBehaviour
{    
    AudioSource audioBass;
    [SerializeField] float timeFadeAudio;
    SpriteRenderer spriteRenderer;
    public bool randomAnimationStartTime = false;
    public Sprite[] idleAnimation, collectedAnimation; 
    internal int frame = 0;
    internal Sprite[] sprites = new Sprite[0];
    internal bool collected = false;
    internal TokenController controller;
        Animator anim;
    private void Awake()
    {
        audioBass = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
            

        gameObject.tag = "Instrument";
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
        if (collected) return;
        //disable the gameObject and remove it from the controller update list.
        frame = 0;
        sprites = collectedAnimation;
        if (controller != null)
            collected = true;

         spriteRenderer.enabled = false;

            }
        }
    }
}
