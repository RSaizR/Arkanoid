using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Brick : MonoBehaviour
{
  public AudioSource audio;


  void OnCollisionEnter2D(Collision2D collisionInfo)
  {
    Destroy(gameObject);
    playButton();
    
    /*  if (completed.Length < cuantos)
      {
        bool playOutput = EditorUtility.DisplayDialog("ARKANOID", "YOU WIN", "Close", "Restart");
        if (playOutput)
          Application.Quit();
      }*/
  }

  public void playButton()
  {
    audio.Play();
  }
}
