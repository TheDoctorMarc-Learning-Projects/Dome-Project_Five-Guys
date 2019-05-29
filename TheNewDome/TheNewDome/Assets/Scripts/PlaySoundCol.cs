using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundCol : MonoBehaviour
{

    public AudioSource theSound; 
    // Start is called before the first frame update
    void Start()
    {
        theSound = GetComponent<AudioSource> (); 
    }

  
    void OnTriggerEnter(Collider col)
    {
        theSound.Play (); 
    } 
}
