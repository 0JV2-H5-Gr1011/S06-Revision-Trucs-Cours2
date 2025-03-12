using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Campignons : MonoBehaviour
{

     [SerializeField] private float _distanceMaximale;
     [SerializeField] GameObject _prefabOriginal;

     [SerializeField] private Transform _positionDrapeau; 
    [SerializeField] private Transform _positionBoite;   

    // Start is called before the first frame update
    void Start()
    {

          float valeurAleatoire = Random.value;
         


   
         if(valeurAleatoire > 0.5f){

            transform.position = _positionDrapeau.position;


         }

          else
        {
            // Placer sur l'île avec la boîte
            transform.position = _positionBoite.position;
        }

     

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
