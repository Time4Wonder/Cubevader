using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Enviroment
{
    public class EnMovment : MonoBehaviour
    {
        private Vector3 movmentVector = new Vector3(0, 0, -1);
        public float speed = 10;

        private void Update()
        {
            transform.Translate(movmentVector * speed * Time.deltaTime);
        }
    }
}
