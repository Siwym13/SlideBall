using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;



public class BallMove : MonoBehaviour
{  
    static Rigidbody rb;
    Animator anim;
    public float moveSpeed = 0.5f;
    float dirX, dirY;
    public static bool youWin;
    static bool moveAllowed;
    static bool isDead;
    float nominalSpeed;
    float audioSpeed;
    int sounds;
    bool audioOn;
 
    [SerializeField]
    GameObject nextMenu;

    AudioSource audio;
    [SerializeField]
    AudioClip clip;


    // Start is called before the first frame update
    void Start()
    {
        nextMenu.gameObject.SetActive(false);        
        rb = GetComponent<Rigidbody>();
        youWin = false;
        isDead = false;
        moveAllowed = true;
        anim = GetComponent<Animator>();
        anim.SetBool("BallDead", isDead);
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        nominalSpeed = rb.velocity.magnitude;
        audioSpeed = Mathf.Clamp(nominalSpeed / 10, 0, 1);
        audio.pitch = Mathf.Clamp( audioSpeed , 0 , 1);
        dirX = Input.acceleration.x * moveSpeed;
        dirY = Input.acceleration.y * moveSpeed;

        if (sounds == 0)
        {
            if (nominalSpeed >= 0.1 && !audio.isPlaying)
            {
                audio.Play();
            }
        }
        
        else if (nominalSpeed < 0.1)
        {
            audio.Pause();
        }
        

        if (youWin)
        {
            moveAllowed = false;
            anim.SetBool("BallDead", true);
            rb.velocity = Vector2.zero;
            Invoke("NextMenu", 0.7f);
        }
    }


    void FixedUpdate()
    {
        if (moveAllowed)
        {
            rb.velocity = new Vector2(rb.velocity.x + dirX, rb.velocity.y + dirY);
        }
    }

    public static void SetYouWin()
    {
        youWin = true;
    }

    void NextMenu()
    {
        nextMenu.gameObject.SetActive(true);
    }

    public static void Pauza()
    {
        moveAllowed = false;
        rb.velocity = Vector2.zero;
    }

    public static void Play()
    {
        moveAllowed = true;
    }
}
