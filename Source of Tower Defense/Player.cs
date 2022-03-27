using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static int Money;
    public int startMoney = 300;
    public GameObject win;
    public int index;

    // Start is called before the first frame update
    void Start()
    {
        Money = startMoney;
    }

    // Update is called once per frame
    void Update()
    {
        if (Enemy.killedEnemy >= 80)
        {
            win.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
