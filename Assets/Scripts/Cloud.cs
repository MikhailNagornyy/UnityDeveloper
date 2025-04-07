using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TZ
{
    public class Cloud : MonoBehaviour
    {
        [SerializeField] private ParticleSystem m_particleSystem;
        void Start()
        {
            m_particleSystem.Stop();
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void PlayFx()
        {
            m_particleSystem.Play();
        }
        public void StopFx()
        {
            m_particleSystem.Stop();
        }
    }
}