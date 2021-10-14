using System;
using System.Collections;
using System.Collections.Generic;
using powerUps;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private Shot shot;
    [SerializeField] private int bulletsAmount = 1;
    [SerializeField] private float bulletsSpeed = 1;
    private void Awake()
    {
        //Cursor.visible = false;
    }
    
    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            shot.bulletSpeed = bulletsSpeed;
            shot.Create(transform.position, bulletsAmount);
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
        }
    }
}
