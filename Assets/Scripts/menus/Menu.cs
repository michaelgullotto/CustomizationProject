using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioSource music;
    void Start()
    {
        //plays music
        music.Play();
    }

    public void Play()
    {
        // loads game scene
        SceneManager.LoadScene(1);
    }


}
