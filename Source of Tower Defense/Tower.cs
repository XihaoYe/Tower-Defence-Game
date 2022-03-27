using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    private Transform target;
    private Enemy targetEnemy;
    public float range = 15f;
    public Transform Muzzle;
    public GameObject bulletPrefab;
    public float fireRate = 1f;
    private float fireCountdown = 0f;
    public Transform TurnAround;
    public float turnSpeed = 10f;
    public string enemyTag = "Enemy";
    public AudioSource attackSound;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
        attackSound = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 roatation = Quaternion.Lerp(TurnAround.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        TurnAround.rotation = Quaternion.Euler(0f, roatation.y, 0f);

        if (fireCountdown <= 0f)
        {
            shoot();
            attackSound.Play();
            animator.SetTrigger("Attack1Trigger");
            fireCountdown = 1f / fireRate;
        }
        fireCountdown -= Time.deltaTime;
    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
            targetEnemy = nearestEnemy.GetComponent<Enemy>();
        }
        else
        {
            target = null;
        }
    }

    void shoot()
    {
        GameObject bullet = (GameObject)Instantiate(bulletPrefab, Muzzle.position, Muzzle.rotation);
        Bullet bulletScript = bullet.GetComponent<Bullet>();
        if (bulletScript != null) bulletScript.Seak(target);
    }
}
