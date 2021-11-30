using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{

    Ray ray;

    // Start is called before the first frame update
    void Start()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        // Recibe si se hizo click
        if (Input.GetMouseButtonDown (0)) {
          //Debug.Log ("Mouse hizo click!");

          // Resetea el rayo con la posición del mouse
          ray = Camera.main.ScreenPointToRay (Input.mousePosition); 
          RaycastHit[] hits = Physics.RaycastAll (ray);

          foreach (RaycastHit hit in hits) {
              if (hit.collider.gameObject.tag == "Enemigo") {

                  hit.transform.gameObject.GetComponent<Enemigo>().RecibirDano();
                  Debug.Log ("Toqué un enemigo");
              }
              if (hit.collider.gameObject.tag == "Pared") {
                  Debug.Log ("Toqué una pared");
              }
          }
      } 
    }
}
