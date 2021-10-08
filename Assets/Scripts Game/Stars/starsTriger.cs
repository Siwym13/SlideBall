using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starsTriger : MonoBehaviour
{
    [SerializeField]
    GameObject starsButton;

    void OnTriggerEnter(Collider col)
    {
        Stars.IfColect();
        starsButton.gameObject.SetActive(false);
    }
}
