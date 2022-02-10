using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LVLMenu : MonoBehaviour
{
    AudioSource audio;
    [SerializeField]
    AudioClip clip;

    int sounds;

    void Start()
    {
        sounds = PlayerPrefs.GetInt("soundsON");
        audio = GetComponent<AudioSource>();
    }

    public void Poziom1()
    {
        if (sounds == 0)
        {
            audio.Play();
        }
        SceneManager.LoadScene("lvl_1");
    }

    void Poziom2()
    {
        if (sounds == 0)
        {
            audio.Play();
        }
        SceneManager.LoadScene("lvl_2");
    }

    void Poziom3()
    {
        if (sounds == 0)
        {
            audio.Play();
        }
        SceneManager.LoadScene("lvl_3");
    }

    void Poziom4()
    {
        if (sounds == 0)
        {
            audio.Play();
        }
        SceneManager.LoadScene("lvl_4");
    }

    void Poziom5()
    {
        if (sounds == 0)
        {
            audio.Play();
        }
        SceneManager.LoadScene("lvl_5");
    }

    void Poziom6()
    {
        if (sounds == 0)
        {
            audio.Play();
        }
        SceneManager.LoadScene("lvl_6");
    }

    void PoziomMenu()
    {
        if (sounds == 0)
        {
            audio.Play();
        }
        SceneManager.LoadScene("Menu");
    }  
}

