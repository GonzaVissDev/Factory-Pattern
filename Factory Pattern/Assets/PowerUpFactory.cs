using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;


namespace PowerUps { 

public class PowerUpFactory : MonoBehaviour
{
        //El patron Factory se caracteriza por tener un metodo create que devuleve la clase padre de la familia de objetos que vamos a crear.
        //Vamos hacer una lista,pero al hacerlo por id (queremos evitar recorrerlo siempre que necesitemos uno) asi que creamos un diccionario.
       [SerializeField] private PowerUp[] _powerUp;

        private Dictionary<string, PowerUp> _idToPowerUp;


        //-------[Recorrido del diccionario]-------
        private void Awake()
        {
            _idToPowerUp = new Dictionary<string, PowerUp>();
           
            foreach (var powerup in _powerUp)
            {
                _idToPowerUp.Add(powerup.Id, powerup);
            }
        }



        //El patron Factory necesita instanciar el objeto.
        public PowerUp Create(string ID)
        {
             if(!_idToPowerUp.TryGetValue(ID, out var powerUp))
            {
                throw new Exception(message: $"power whit id {ID} does not exit");
            }


            return Instantiate(powerUp);
   
        }

}


}
