using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    [SerializeField] private float velocidadRotacion = 0;
    [SerializeField] Transform Planeta;

    [SerializeField] Transform Satelite;
 
    // Update is called once per frame
    void Update()
    {
     Planeta.Rotate(new Vector3(velocidadRotacion * Time.deltaTime,0,0));  

     Satelite.RotateAround(Planeta.position,Vector3.right,velocidadRotacion * Time.deltaTime);
    }
}


