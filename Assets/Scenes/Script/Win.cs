using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public void nextLevel()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        index++;
        SceneManager.LoadScene(index);
        Enemy.killedEnemy = 0;
        Time.timeScale = 1f;
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
