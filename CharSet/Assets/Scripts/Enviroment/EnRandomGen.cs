using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evader.Enviroment
{
    public class EnRandomGen : MonoBehaviour
    {
        

        public GameObject[] obstacle;
        private Vector3 spawnCoords;
        

        private void Start()
        {
            SpawnFiveChunks();
        }

        private void Update()
        {
            if(spawnCoords.z - GameObject.FindGameObjectWithTag("Player").transform.position.z <= 50)
            {
                SpawnFiveChunks();
            }
        }

        public void SpawnFiveChunks()
        {
            int rnIndex;

            for (int i = 0; i < 5; i++)
            {
                rnIndex = Random.Range(0, 3);
                Instantiate(obstacle[rnIndex], spawnCoords, Quaternion.identity);
                spawnCoords.z += 20;
            }
        }

        
    }

}
