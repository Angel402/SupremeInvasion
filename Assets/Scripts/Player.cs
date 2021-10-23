using System;
using System.Collections;
using System.Collections.Generic;
using Enemies;
using powerUps;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float health = 4;
    [SerializeField] private Shot shot;
    [SerializeField] private int bulletsAmount = 1;
    [SerializeField] private float bulletsSpeed = 1;

    public float BulletsSpeed => bulletsSpeed;
    private void Awake()
    {
        //Cursor.visible = false;
    }
    
    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            shot.bulletSpeed = bulletsSpeed;
            var position = transform.position;
            shot.Create(new Vector3(position.x, position.y+1, position.x), bulletsAmount);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out PowerUp powerUp))
        {
            var powerUpId = powerUp.Id;
            switch (powerUpId)
            {
                case "BulletsSpeed":
                {
                    bulletsSpeed += 0.01f;
                    break;
                }
                case "BulletsAmount":
                {
                    bulletsAmount += 1;
                    break;
                }
            }
            Destroy(other.gameObject);
        }
        else
        {
            if (!other.gameObject.CompareTag("EnemyShot")) return;
            Destroy(other.gameObject);
            health -= 1;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.TryGetComponent(out Enemy _)) return;
        health -= 1;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
