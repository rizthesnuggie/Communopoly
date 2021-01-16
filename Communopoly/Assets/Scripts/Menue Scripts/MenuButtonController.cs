using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtonController : MonoBehaviour
{
    public GameObject escon;
    public Button yes;
    public Button no;
    public GameObject Mainbut;
    public void Play()
    {
        SceneManager.LoadScene(0);
    }

    public void Options()
    {
        SceneManager.LoadScene(2);
    }

    public void Exit1()
    {
        Mainbut.SetActive(false);
        Exit();
    }

    public void Exit()
    {
        Time.timeScale = 0;
        escon.SetActive(true);
    }

   public void exitrue()
    {
        Application.Quit();
    }
    public void exitfal()
    {
        Time.timeScale = 1;
        Mainbut.SetActive(true);
        escon.SetActive(false);
    }
}


