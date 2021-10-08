using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Diagnostics;


public class NextMenu : MonoBehaviour
{
    [SerializeField]
    GameObject pauseM;

    [SerializeField]
    GameObject playB;

    [SerializeField]
    GameObject pauseB;

    AudioSource audio;
    [SerializeField]
    AudioClip clip;

    int sounds;
    bool youWin;

    void Start()
    {
        pauseM.gameObject.SetActive(false);
        sounds = PlayerPrefs.GetInt("soundsON");
        audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        youWin = BallMove.youWin;

        if(youWin)
        {
            pauseB.gameObject.SetActive(false);
        }
    }

    public void NextLvL()
    {
        if (sounds == 0)
        {
            audio.Play();
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
   
    public void ReturnMenu()
    {
        if (sounds == 0)
        {
            audio.Play();
        }
        SceneManager.LoadScene("Menu");
    }
   
    public void PlayAgain()
    {
        if (sounds == 0)
        {
            audio.Play();
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

    public void PasueButton()
    {
        if (sounds == 0)
        {
            audio.Play();
        }
        pauseB.gameObject.SetActive(false);
        pauseM.gameObject.SetActive(true);
        BallMove.Pauza();
    }

    public void PlayButton()
    {
        if (sounds == 0)
        {
            audio.Play();
        }
        pauseB.gameObject.SetActive(true);
        pauseM.gameObject.SetActive(false);
        BallMove.Play();
    }

    public void ChoseLvL()
    {
        if (sounds == 0)
        {
            audio.Play();
        }
        SceneManager.LoadScene("chose_lvl");
    }

}

