using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarBalas : MonoBehaviour
{

    public Rigidbody projectile;
    public int velocidadProyectil = 10;
    private Vector3 offset;
    // Start is called before the first frame update
  void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        // Se presiona CTRL, lanza el proyectil
        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate the projectile at the position and rotation of this transform
            Rigidbody clone;
            offset = gameObject.transform.forward;
            clone = Instantiate(projectile, transform.position + offset, transform.rotation);

            // Give the cloned object an initial velocity along the current
            // object's Z axis
            clone.velocity = transform.TransformDirection(Vector3.forward * velocidadProyectil);
        }
    }

}
