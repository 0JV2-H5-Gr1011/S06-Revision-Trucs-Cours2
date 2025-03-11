using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjoutBronze : MonoBehaviour
{
    [SerializeField] GameObject _prefabOriginal;


    void Start()
    {

        Vector3 _positionActuelle = transform.position;
        Quaternion _rotationActuelle = transform.rotation; 

        Quaternion _rotation = Quaternion.Euler(0f, 90f, 0f);
        Instantiate(_prefabOriginal, _positionActuelle, _rotationActuelle);
  
    }
}
