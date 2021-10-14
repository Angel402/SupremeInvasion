using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShoots : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Bullet>() != null) {Destroy(other.gameObject);}
    }
}
