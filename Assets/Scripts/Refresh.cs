using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Properties;
using UnityEditor;
using UnityEngine;

namespace TZ
{
    public class Refresh : MonoBehaviour
    {
        public List<GameObject> tools;
        public void Start()
        {
            ChangeTool();
        }
        public void ChangeTool()
        {
            int index = UnityEngine.Random.Range(0, tools.Count);
            SetActiveTool(index);
        }
        private void SetActiveTool(int index)
        {
            for (int i = 0; i < tools.Count; i++)
            {
                tools[i].SetActive(i == index);
            }
        }
    }
}
