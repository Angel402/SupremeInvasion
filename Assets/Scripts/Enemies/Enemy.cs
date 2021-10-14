using System;
using UnityEngine;

namespace Enemies
{
    public abstract class Enemy : MonoBehaviour
    {
        [SerializeField] protected Shot shot;
        [SerializeField] private string id;
        protected int health;
        protected float bulletsSpeed = -0.01f;
        public string ID => id;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Shot")) {TakeDamage(other.gameObject);};
            
        }

        protected abstract void TakeDamage(GameObject enemy);
    }
}