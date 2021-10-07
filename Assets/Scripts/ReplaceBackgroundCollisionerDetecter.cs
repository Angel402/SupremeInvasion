using System;
using UnityEngine;

namespace Gameplay
{
    public class ReplaceBackgroundCollisionerDetecter : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("ReplaceBackgroundCollisioner"))
            {
                var transform1 = transform;
                transform1.position = new Vector3(0,transform1.position.y + 35.9f,0);
            }
        }
    }
}