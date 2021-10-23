using UnityEngine;

namespace powerUps
{
    public class PowerUpsFactory
    {
        private readonly PowerUpsConfiguration _powerUpsConfiguration;

        public PowerUpsFactory(PowerUpsConfiguration powerUpsConfiguration)
        {
            _powerUpsConfiguration = powerUpsConfiguration;
        }

        public PowerUp Create(string id, Vector3 powerUpPosition)
        {
            var powerUp = _powerUpsConfiguration.GetPowerUpById(id);
            var powerUpGO = Object.Instantiate(powerUp);
            powerUpGO.transform.position = powerUpPosition;
            return powerUpGO;

        }
    }
}