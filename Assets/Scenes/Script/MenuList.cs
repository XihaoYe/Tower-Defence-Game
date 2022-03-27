using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuList : MonoBehaviour
{
    public GameObject esc;
    public GameObject menu;
    public GameObject option;
    public AudioSource bgm;
    int a = 0;
    public Text bgmtext;

    public void Restart()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
        Time.timeScale = 1f;
    }

    public void Option()
    {
        option.SetActive(true);
        menu.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Continue()
    {
        esc.SetActive(!esc.activeSelf);
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void BGM()
    {
        if (a == 0)
        {
            bgm.Stop();
            a = 1;
            bgmtext.text = "BGM : OFF";
        }
        else
        {
            bgm.Play();
            a = 0;
            bgmtext.text = "BGM : ON";
        }
    }

    public void Return()
    {
        option.SetActive(false);
        menu.SetActive(true);
    }
}
