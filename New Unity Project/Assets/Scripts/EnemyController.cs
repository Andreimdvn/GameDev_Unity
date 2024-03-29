﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    private Transform enemyHolder;
    public float speed;
    public GameObject shot;
    public Text winText;
    public float fireRate;

    // Start is called before the first frame update
    void Start()
    {
        winText.enabled = false;
        InvokeRepeating("MoveEnemy", 0.1f, 0.3f);
        enemyHolder = GetComponent<Transform>();
    }

    void MoveEnemy()
    {
        enemyHolder.position += Vector3.right * speed;

        foreach(Transform enemy in enemyHolder)
        {
            if (enemy.position.x < -10.5 || enemy.position.x > 10.5)
            {
                speed = -speed;
                enemyHolder.position += Vector3.down * 0.35f;
                return;
            }

            if(Random.value > fireRate)
            {
                Instantiate(shot, enemy.position, enemy.rotation);
            }

            if(enemy.position.y <= -3)
            {
                GameOver.isPlayerDead = true;
                Time.timeScale = 0;
            }
        }

        if (enemyHolder.childCount == 1)
        {
            CancelInvoke();
            InvokeRepeating("MoveEnemy", 0.1f, 0.25f);
        }

        if (enemyHolder.childCount == 0)
        {
            winText.enabled = true;
        }
    }
}
