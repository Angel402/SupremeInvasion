using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Enemies
{
    public class DefaultEnemy : Enemy
    {
        [SerializeField] private Animator animator;
        private static readonly int IsDeath = Animator.StringToHash("isDeath");

        private void Awake()
        {
            health = 2;
            bulletsSpeed = -0.01f;
            StartCoroutine(Positioning());
            shot.bulletSpeed = bulletsSpeed;
        }

        private IEnumerator Positioning()
        {
            yield return new WaitForSeconds(3);
            StartCoroutine(Shot());
        }
        
        private IEnumerator Shot ()
        {
            var shotProbability  = Random.Range(1, 25);
            yield return new WaitForSeconds(shotProbability);
            var transform1 = transform.position;
            shot.bulletSpeed = bulletsSpeed;
            shot.Create(new Vector3(transform1.x, transform1.y-1, transform1.z), 1);
            CreateOtherBullet();
        }

        private void CreateOtherBullet()
        {
            StartCoroutine(Shot());
        }

        protected override void TakeDamage(GameObject enemy)
        {
            if (health <= 1)
            {
                animator.SetBool("isDeath",true);
            }
            else
            {
                health -= 1;
            }
            Destroy(enemy.gameObject);
        }

        private void DestroyGameObject()
        {
            Destroy(gameObject);
        }
    }
    
}