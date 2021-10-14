using UnityEngine;

namespace Enemies
{
    public abstract class Enemy
    {
        [SerializeField] private Shot shot;
        [SerializeField] private int bulletsAmount;
        [SerializeField] private float bulletsSpeed;
        [SerializeField] private string id;

        public string ID => id;

        public class DefaultEnemy : Enemy
        {
            
        }
    }
}