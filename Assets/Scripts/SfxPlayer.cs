using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxPlayer : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx;
    public AudioClip playSfx;

    public void Button()
    {
        src.clip = sfx;
        src.Play();
    }

    public void Start()
    {
        src.clip = sfx;
        src.Play();
    }
}
