using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Evader.Enviroment
{
    public class EnDespawn : MonoBehaviour
    {
        void Update()
        {
            if (GameObject.FindGameObjectWithTag("Player").transform.position.z - gameObject.transform.position.z > 50)
                Destroy(gameObject);
        }
    }
}

