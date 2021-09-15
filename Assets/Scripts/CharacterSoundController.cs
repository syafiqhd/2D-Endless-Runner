using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSoundController : MonoBehaviour
{
    public AudioClip jump;
    public AudioClip scoreHighlight;
    public AudioClip fallDown;
    public AudioClip gameOver;

    private AudioSource audioPlayer;

    private void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

    public void PlayJump()
    {
        audioPlayer.PlayOneShot(jump);
    }

    public void PlayScoreHighlight()
    {
        audioPlayer.PlayOneShot(scoreHighlight);
    }

    public void PlayFallDown() 
    {
        audioPlayer.PlayOneShot(fallDown);
    }

    public void PlayGameOver() 
    {
        audioPlayer.PlayOneShot(gameOver);
    }
}
