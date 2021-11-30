using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Camera mainCamera;
    public int alturaCamara = 35;
    public int distanciaAtras = 0;
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float playerSpeed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        if(TocaFrente()){
            Debug.Log("Me toco desde el frente");
        }
        groundedPlayer = IsGrounded();//controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if(groundedPlayer){
            controller.Move(move * Time.deltaTime * playerSpeed);   
        }
        else{
            controller.Move(move * Time.deltaTime * (playerSpeed/2)); 
        }
        

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

        MoveCamera();
    }

         void MoveCamera()
    {
        mainCamera.transform.position = new Vector3(transform.position.x , transform.position.y + alturaCamara, transform.position.z - distanciaAtras);
    }

    public bool TocaFrente(){
        Debug.Log("IsGrounded");
        LayerMask mask = LayerMask.GetMask("Default");
        
        RaycastHit hit;
        if(Physics.SphereCast( transform.position, 0.3f,  transform.forward, out hit, 0.7f, mask )){
            if(hit.transform.tag == "Finish"){
                   return true;
            }
            else{
                return false;
            }
        }

        return false;

        
    }

    public bool IsGrounded(){
        Debug.Log("IsGrounded");
        LayerMask mask = LayerMask.GetMask("Default");
        
        RaycastHit hit;
        return Physics.SphereCast(
            transform.position,
            0.1f,
            Vector3.down,
            out hit,
            0.5f,
            mask
        );
    }
}