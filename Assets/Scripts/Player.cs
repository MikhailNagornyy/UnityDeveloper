using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Golf
{
    public class Player : MonoBehaviour
    {
        public Transform stick;
        public Transform helper;
        private Vector3 m_LastPosition;
        private bool m_isDown = false;
        public float range = 40f;
        public float speed = 500f;
        public float power = 5f;

        public void Update()
        {
            m_LastPosition = helper.position;
            m_isDown = Input.GetMouseButton(0);
            Quaternion rot = stick.localRotation;
            Quaternion toRot = Quaternion.Euler(0, 0, m_isDown ? range : -range);
            rot = Quaternion.RotateTowards(rot, toRot, speed * Time.deltaTime);
            stick.localRotation = rot;
        }
        public void OnCollisionStick(Collider collider)
        {
            Debug.Log(collider, this);
            if (collider.TryGetComponent(out Rigidbody body))
            {
                var dir = (helper.position - m_LastPosition).normalized;
                body.AddForce(dir * power, ForceMode.Impulse);

                if(collider.TryGetComponent(out Stone stone))
                {
                    stone.isAffect = true;
                }
            }
        }
    }
}
