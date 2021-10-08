using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallSounds : MonoBehaviour
{
    AudioSource audio;
    [SerializeField]
    AudioClip clip;

    int sounds;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        sounds = PlayerPrefs.GetInt("soundsON");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (sounds == 0)
        {
            audio.Play();
        }
    }
}
