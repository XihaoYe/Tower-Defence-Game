using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Home : MonoBehaviour
{
    public float startHealth = 5;
    public float health;
    public Slider healthBar;
    private bool isDead = false;
    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        health = startHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0 && !isDead)
        {
            isDead = true;
            Destroy(gameObject);
            Time.timeScale = 0f;
            gameOver.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Enemy")
        {
            health -= 1;
            healthBar.value = health;
        }
    }

}
