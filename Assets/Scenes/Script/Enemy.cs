using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float startHealth = 200;
    public float health;
    public int worth = 50;
    public GameObject EnemyDeathEffect;
    public Slider healthBar;
    private bool isDead = false;
    public static int killedEnemy = 0;

    // Start is called before the first frame update
    void Start()
    {
        health = startHealth;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        healthBar.value = health;

        if (health <= 0 && !isDead)
        {
            isDead = true;
            Player.Money += worth;
            killedEnemy++;
            GameObject effectIns = (GameObject)Instantiate(EnemyDeathEffect, transform.position, transform.rotation);
            Destroy(effectIns, 5f);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Home")
        {
            Destroy(gameObject);
            killedEnemy++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
