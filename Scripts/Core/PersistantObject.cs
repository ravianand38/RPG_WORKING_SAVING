using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RPG.Core
{
    public class PersistantObject : MonoBehaviour
    {
        [SerializeField] GameObject persistantObjectPrefab;

        static bool hasSpawn = false;

        private void Awake()
        {
            if (hasSpawn) return;

            SpawnPersistantObjects();

            hasSpawn = true;

            

        }

        private void SpawnPersistantObjects()
        {
            GameObject persistantObject = Instantiate(persistantObjectPrefab);

            DontDestroyOnLoad(persistantObject);
        }
    }
}


