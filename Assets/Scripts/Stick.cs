using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Golf
{
    public class Stick : MonoBehaviour
    {
        public UnityEvent<Collider> onColiision;

        private void OnCollisionEnter(Collision collision)
        {
            onColiision.Invoke(collision.collider);
        }
    }
}
