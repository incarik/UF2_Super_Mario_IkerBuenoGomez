using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bandera : MonoBehaviour
{
    AudioSource source;
    public AudioClip lvl1Music;

    // Start is called before the first frame update
    void Start()
    {
        
    }
     void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        source.Play();
    }
    
}
