using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

namespace Evader.Player
{
    public class PlayerMovment : MonoBehaviour
    {
        private float acceleration = 10f;
        public float speed = 4;
        private CharacterController controller;
        private Vector3 movmentVector;

        // Start is called before the first frame update
        void Start()
        {
            controller = GetComponent<CharacterController>();
        }

        // Update is called once per frame
        void Update()
        {
            movmentVector = new Vector3(Input.GetAxis("Horizontal") * speed, 0f , acceleration);
            controller.Move(movmentVector * Time.deltaTime);
            acceleration += 0.001f;
            speed += 0.001f;
        }
    }
}

