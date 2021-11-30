using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personaje : MonoBehaviour
{
    public Text TextoPuntos;
    public GameObject Ganaste;
    private int puntos;

    // Start is called before the first frame update
    void Start()
    {
        Ganaste.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Función para chocar con objetos físicos (no trigger)
    void OnCollisionEnter(Collision collision) // collision es el objeto con el que choco
    {
        if (collision.gameObject.tag == "Enemigo") // Pregunto si el objeto tiene el tag Enemigo
        {
            Debug.Log("Choqué con un enemigo");
            Destroy(gameObject);    // Funcion para destruir ESTE objeto


        }
        else if (collision.gameObject.tag == "Pared") // Pregunto si el objeto tiene el tag Pared
        {
            Debug.Log("Choqué con una pared");
        }
        
    }

    // Función para chocar con objetos no físicos (los trigger)
    void OnTriggerEnter(Collider collision) // collision es el objeto con el que choco
    {
        // 
        if (collision.gameObject.tag == "Moneda") // Pregunto si el objeto tiene el tag Moneda
        {
            Debug.Log("Choqué con una monedita");
            puntos += 1;
            TextoPuntos.text = puntos.ToString();
            Destroy(collision.gameObject);      // Funcion para destruir el objeto

            if(puntos >= 3){
                Ganaste.SetActive(true);
            }
        }
    }

     

}
