using System;
using UnityEngine;

namespace Enemies
{
    public class EnemiesGenerator : MonoBehaviour
    {
        private int level = 0;
        private EnemyFactory _enemyFactory;
        [SerializeField] private EnemiesConfiguration _enemiesConfiguration;

        private void Awake()
        {
            _enemyFactory = new EnemyFactory(Instantiate(_enemiesConfiguration));
        }

        private void Start()
        {
            if (level == 0)
            {
                GenerateFirstEnemies();
            }
        }

        private void GenerateFirstEnemies()
        {
            for (var i = -7f; i <=7; i+=2)
            {
                for (var j = 4.5f; j >= 1.5f; j-=1)
                {
                    _enemyFactory.Create("DefaultEnemy", new Vector3(i, j, 0));
                }
            }
        }
    }
}