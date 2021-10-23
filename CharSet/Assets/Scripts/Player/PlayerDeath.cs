using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evader.Player
{
    public class PlayerDeath : MonoBehaviour
    {
        private CharacterController controller;
        // Start is called before the first frame update
        void Start()
        {
            controller = GetComponent<CharacterController>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Obstacle"))
                Destroy(gameObject);
        }
    }
}

