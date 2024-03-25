using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Target : MonoBehaviour
{
    private AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    { 
        
    }
    public void Hit() 
    {
        // play sound
        audioSrc.Play();
        print("played");
    }
}
