using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PowerUps { 


    //Script de ejemplo para instanciar el Power Up que necesitamos.

public class PowerUpSpawner : MonoBehaviour
{
        [SerializeField] private PowerUpFactory _powerupFactory;

    // Update is called once per frame
    void Update()
    {

            if (Input.GetKey(KeyCode.A))
            {
                _powerupFactory.Create(ID: "Speed");
            }
        
    }
}
}