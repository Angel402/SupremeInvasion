using Unity.Mathematics;
using UnityEngine;

namespace Enemies
{
    public class RotateEnemy : MonoBehaviour
    {
        public void Rotate()
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }
}