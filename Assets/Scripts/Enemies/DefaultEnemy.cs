using System;
using System.Collections;
using powerUps;
using UnityEngine;
using Random = UnityEngine.Random;
using DG.Tweening;

namespace Enemies
{
    public class DefaultEnemy : Enemy
    {
        [SerializeField] private Animator animator;
        private PowerUpsFactory _powerUpsFactory;
        [SerializeField] private PowerUpsConfiguration _powerUpsConfiguration;

        private void Awake()
        {
            health = 2;
            bulletsSpeed = -0.01f;
            StartCoroutine(Positioning());
            shot.bulletSpeed = bulletsSpeed;
            _powerUpsFactory = new PowerUpsFactory(Instantiate(_powerUpsConfiguration));
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
            var sequence = DOTween.Sequence();
            sequence.Insert(0, gameObject.GetComponent<SpriteRenderer>().DOColor(Color.red, 0.1f));
            sequence.Insert(0, gameObject.GetComponent<Transform>().DOShakePosition(.4f, .1f, 100));
            sequence.Insert(0.1f, gameObject.GetComponent<SpriteRenderer>().DOColor(Color.white, 0.1f));
            if (health <= 1)
            {
                animator.SetBool("isDeath",true);
                GeneratePowerUp();
            }
            else
            {
                health -= 1;
            }
            Destroy(enemy.gameObject);
        }

        private void GeneratePowerUp()
        {
            var canSpawnPowerUp = Random.Range(0, 66);
            switch (canSpawnPowerUp)
            {
                case 0:
                    _powerUpsFactory.Create("BulletsSpeed", transform.position);
                    break;
                case 1:
                    _powerUpsFactory.Create("BulletsAmount", transform.position);
                    break;
            }
        }

        private void DestroyGameObject()
        {
            Destroy(gameObject);
        }
    }
    
}