using System;
using UnityEngine;
using System.Collections.Generic;

namespace Enemies
{
    [CreateAssetMenu(menuName = "Custom/Enemies configuration")]
    public class EnemiesConfiguration : ScriptableObject
    {
        [SerializeField] private Enemy[] _enemies;
        private Dictionary<string, Enemy> _idToEnemies;
        
        private void Awake()
        {
            
            _idToEnemies = new Dictionary<string, Enemy>();
            foreach (var enemy in _enemies)
            {
                _idToEnemies.Add(enemy.Id, enemy);
            }
        }
        
        public Enemy GetEnemyById(string id)
        {
            if (! _idToEnemies.TryGetValue(id, out var enemy))
            {
                throw new Exception($"PowerUp with id {id} does not exit");
            }
            else
                return enemy;
        }
    }
}