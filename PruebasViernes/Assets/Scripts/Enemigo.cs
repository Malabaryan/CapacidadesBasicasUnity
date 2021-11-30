using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int vida = 1;
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
            RecibirDano();
            Destroy(collision.gameObject);
        }
        
        
        
    }

    public void RecibirDano(){
        vida -= 1;
        if(vida == 0){
            
            Destroy(gameObject);    // Funcion para destruir ESTE objeto
        }
    }
}
