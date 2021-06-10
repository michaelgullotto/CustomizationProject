using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pausepanel;
    public bool isPaused = false;
   

   
    void Update()
    {
        /// toogles pasue menu
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused == true)
            {
                pausepanel.SetActive(false);
            }
            else if  (isPaused == false)
            {
                pausepanel.SetActive(true);
            }

        }
   }

    //loads protypings sence from game dosent work in protyping use main menu to loop around
    public void LoadNext()
    {
        SceneManager.LoadScene(2);
    }

   // exits game
    public void Exit()
    {

        Application.Quit();
    }
    //loads main menu
    public void MainMeu()
    {
        SceneManager.LoadScene(0);
    }
}
