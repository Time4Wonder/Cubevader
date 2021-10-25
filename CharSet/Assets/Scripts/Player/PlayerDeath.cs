using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evader.Player
{

    public class PlayerDeath : MonoBehaviour
    {
        public GameObject hud;
        public GameObject deathScreen;

        private CharacterController controller;
        // Start is called before the first frame update
        void Start()
        {
            controller = GetComponent<CharacterController>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Obstacle"))
                Death();
        }

        public void Death()
        {
            Time.timeScale = 0f;
            deathScreen.SetActive(true);
            hud.SetActive(false);
        }
    }
}

