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


        void Start()
        {
            controller = GetComponent<CharacterController>();
        }

        public bool Death()
        {
            Time.timeScale = 0f;
            deathScreen.SetActive(true);
            hud.SetActive(false);

            return true;
        }

        private void OnControllerColliderHit(ControllerColliderHit hit)
        {
            if(hit.gameObject.CompareTag("Obstacle"))
            {
                Death();
            }
        }
    }
}

