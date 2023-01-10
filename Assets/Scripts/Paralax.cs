using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
   [SerializeField] private Transform segundoPlano;
   [SerializeField] private float velSegundo = 0.7f;

    [SerializeField] private Transform tercerPlano;
   [SerializeField] private float velTercer = 0.4f;

    // Update is called once per frame
    void Update()
    {
        segundoPlano.Translate(velSegundo * Time.deltaTime * Vector3.left);

        tercerPlano.Translate(velTercer * Time.deltaTime * Vector3.left);
        
    }
}
