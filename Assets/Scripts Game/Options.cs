﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    [SerializeField]                  
    GameObject resetConfirm;

    [SerializeField]
    GameObject resetSuccess;

    [SerializeField]
    GameObject soundsOff;

    AudioSource audio;
    [SerializeField]
    AudioClip clip;

    int sounds; 

    // Start is called before the first frame update
    void Start()
    {
        sounds = PlayerPrefs.GetInt("soundsON");
        resetConfirm.gameObject.SetActive(false);
        resetSuccess.gameObject.SetActive(false);
        audio = GetComponent<AudioSource>();

        if (sounds == 0)
        {
            soundsOff.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        sounds = PlayerPrefs.GetInt("soundsON");
    }

    void MenuReturn()
    {
        if (sounds == 0)
        {
            audio.Play();
        }
        SceneManager.LoadScene("Menu");
    }

    void ButtonResetGame()
    {
        if (sounds == 0)
        {
            audio.Play();
        }
        resetConfirm.gameObject.SetActive(true);
    }

    void ResetConfirmFalse()
    {
        if (sounds == 0)
        {
            audio.Play();
        }
        resetConfirm.gameObject.SetActive(false);
    }

     void ResetConfirmeTrue()
    {
        if (sounds == 0)
        {
            audio.Play();
        }
        PlayerPrefs.DeleteAll();
        resetConfirm.gameObject.SetActive(false);
        resetSuccess.gameObject.SetActive(true);
    }

     void ResetSuccessOk()
    {
        if (sounds == 0)
        {
            audio.Play();
        }
        resetSuccess.gameObject.SetActive(false);
    }

    void GameSoundsOff()
    {
        soundsOff.gameObject.SetActive(true);
        PlayerPrefs.SetInt("soundsON", 1);
    }

     void GameSoundOn()
    {
        soundsOff.gameObject.SetActive(false);
        PlayerPrefs.SetInt("soundsON", 0);
        audio.Play();
    }
}
