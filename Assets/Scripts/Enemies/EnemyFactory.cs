using UnityEngine;

namespace Enemies
{
    public class EnemyFactory
    {
        private readonly EnemiesConfiguration _enemiesConfiguration;

        public EnemyFactory(EnemiesConfiguration enemiesConfiguration)
        {
            _enemiesConfiguration = enemiesConfiguration;
        }

        public Enemy Create(string id, Vector3 enemyPosition)
        {
            var enemy = _enemiesConfiguration.GetEnemyById(id);
            var enemyGO = Object.Instantiate(enemy);
            enemyGO.transform.position = enemyPosition;
            return enemyGO;
        }
    }
}