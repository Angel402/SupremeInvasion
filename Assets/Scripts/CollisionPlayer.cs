using System;
using System.Collections;
using System.Collections.Generic;
using powerUps;
using UnityEngine;

public class CollisionPlayer : MonoBehaviour
{
    [SerializeField] private PlayerFacade _playerFacade;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("pum");
        /*if (TryGetComponent(SpeedPowerUp other))
        {
            _playerFacade.IncreaseShootSpeed(other.gameObject);
        }*/
    }
}
