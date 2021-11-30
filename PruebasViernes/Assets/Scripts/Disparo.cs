using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject Personaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Preguntamos si se ejecutó el botón de Fire1
        if (Input.GetButtonDown("Fire1")) {

            // Instanciamos un RaycastHit
            RaycastHit hit;

            // Tiramos el raycast
            if(Physics.Raycast(transform.position + gameObject.transform.forward, transform.forward, out hit, 10f)){

                if(hit.transform.tag == "Enemigo"){
                    hit.transform.gameObject.GetComponent<Enemigo>().RecibirDano();
                    Debug.DrawRay(transform.position, transform.forward * 10f, Color.green);
                    //Destroy(hit.transform.gameObject);
                }
                else{
                    Debug.DrawRay(transform.position, transform.forward * 10f, Color.red);
                }

                
            }
        }
    }
}
