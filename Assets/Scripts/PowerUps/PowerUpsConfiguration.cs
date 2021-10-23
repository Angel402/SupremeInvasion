using System;
using System.Collections.Generic;
using UnityEngine;

namespace powerUps
{
    [CreateAssetMenu(menuName = "Custom/PowerUps configuration")]
    public class PowerUpsConfiguration : ScriptableObject
    {
        [SerializeField] private PowerUp[] _powerUps;
        private Dictionary<string, PowerUp> _idToPowerUps;
        
        
        private void Awake()
        {
            
            _idToPowerUps = new Dictionary<string, PowerUp>();
            foreach (var powerUp in _powerUps)
            {
                _idToPowerUps.Add(powerUp.Id, powerUp);
            }
        }
        
        public PowerUp GetPowerUpById(string id)
        {
            if (! _idToPowerUps.TryGetValue(id, out var powerUp))
            {
                throw new Exception($"PowerUp with id {id} does not exit");
            }
            else
                return powerUp;
        }
    }
}