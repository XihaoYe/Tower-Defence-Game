using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
	public GameObject menu;
    public int time = 2;
    public Text timeNum;

    public void Click()
	{
		menu.SetActive(!menu.activeSelf);
        if (menu.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void SpeedUp()
    {
        if ( time > 0)
        {
            Time.timeScale = Time.timeScale * 2;
            timeNum.text = "Speed*" + Time.timeScale.ToString();
            time -= 1;
        }          
        else
        {
            Time.timeScale = 1f;
            timeNum.text = "Speed*" + Time.timeScale.ToString();
            time = 2;
        }
    }
}
