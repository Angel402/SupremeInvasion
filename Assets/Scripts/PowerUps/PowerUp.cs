using System.Collections;
using UnityEngine;

namespace powerUps
{
    public abstract class PowerUp : MonoBehaviour
    {
        [SerializeField] private string id;
        public string Id => id;
    }
}

