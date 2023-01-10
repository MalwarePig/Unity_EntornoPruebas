using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    [SerializeField] private Transform Inicio;

    [SerializeField] private Transform Fin;

    [SerializeField] public List<GameObject> props;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Spawn();
    }

     void Spawn()
    {
        foreach (GameObject prop in props)
        {
            if (prop.transform.position.x <= Fin.position.x)
            {
                prop.transform.position = new Vector3(Inicio.position.x, prop.transform.position.y, prop.transform.position.z);
            }
        }
    }
}
