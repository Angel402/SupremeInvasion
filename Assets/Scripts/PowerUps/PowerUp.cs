using System;
using System.Collections;
using UnityEngine;

namespace powerUps
{
    public abstract class PowerUp : MonoBehaviour
    {
        [SerializeField] private string id;
        public string Id => id;

        private void Update()
        {
            transform.Translate(new Vector3(0,-.005f,0));
        }
    }
}

