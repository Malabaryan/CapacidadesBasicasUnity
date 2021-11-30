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
        //if (Input.GetButtonDown("Fire1")) {
            RaycastHit hit;
            if(Physics.Raycast(transform.position, transform.forward, out hit, 10f)){
                if(hit.transform.tag == "Enemigo"){
                    //hit.transform.gameObject.GetComponent<
                    Debug.DrawRay(transform.position, transform.forward * 10f, Color.green);
                }
                else{
                    Debug.DrawRay(transform.position, transform.forward * 10f, Color.red);
                }
            }
        //}
    }
}
