using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setVolume : MonoBehaviour
{
  public Slider slider;
  public AudioSource source;

    // Update is called once per frame
    void Update()
    {
      source.volume = slider.value;
      globalVar.volValue = slider.value;
    }
}
