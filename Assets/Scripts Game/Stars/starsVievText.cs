using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class starsVievText : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI starsViev;

    int allStars;
    int stars1;
    int stars2;
    int stars3;
    int stars4;
    int stars5;
    int stars6;

    void Start()
    {
        //Pobieranie Starsów
        stars1 = PlayerPrefs.GetInt("starsColectRecord1");
        stars2 = PlayerPrefs.GetInt("starsColectRecord2");
        stars3 = PlayerPrefs.GetInt("starsColectRecord3");
        stars4 = PlayerPrefs.GetInt("starsColectRecord4");
        stars5 = PlayerPrefs.GetInt("starsColectRecord5");
        stars6 = PlayerPrefs.GetInt("starsColectRecord6");
        //Dodawanie Starsów 
        allStars = stars1 + stars2 + stars3 + stars4 + stars5 + stars6;
        //Wyświetlanie Starsów
        starsViev.text = allStars.ToString();
    }
}
