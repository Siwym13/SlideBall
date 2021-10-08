using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
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

    public void GameStart()
    {
        if (sounds == 0)
        {
            audio.Play();
        }
        SceneManager.LoadScene("lvl_1");
    }

    public void ChoseLvL()
    {
        if (sounds == 0)
        {
          audio.Play();
        }
        SceneManager.LoadScene("chose_lvl");
    }

    public void Options()
    {
        if (sounds == 0)
        {
           audio.Play();
        }
        SceneManager.LoadScene("options");
    }
}
