using System.Collections;
using UnityEngine;

namespace powerUps
{
    public abstract class PowerUp : MonoBehaviour
    {
        [SerializeField] private int id;
        public int Id => id;
    }
}

