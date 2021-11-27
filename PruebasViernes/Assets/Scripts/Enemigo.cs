using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) // collision es el objeto con el que choco
    {
        if (collision.gameObject.tag == "Bala") // Pregunto si el objeto tiene el tag Enemigo
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);    // Funcion para destruir ESTE objeto
        }
        
        
    }
}
