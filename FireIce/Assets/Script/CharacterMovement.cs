using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    public bool activeCharacter;
    public float speed;
    public float rotationSpeed = 360;
    public bool isMoving;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (activeCharacter)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
            //movementDirection.Normalize();

            transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

            if (horizontalInput > 0 || verticalInput > 0 || horizontalInput < 0 || verticalInput < 0)
            {
                isMoving = true;
            }
            else
            {
                isMoving = false;
            }

            if (movementDirection != Vector3.zero)
            {
                transform.forward = movementDirection;
            }

            if (isMoving == true)
            { 
                animator.SetTrigger("Walk");
            }
            else
            {
                animator.SetTrigger("IdleEvent");
            }
            //transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed * Time.deltaTime);
        }


        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.F) || Input.GetKeyUp(KeyCode.Space))
        {
            Switch();
        }
    }

    public void Switch()
    {
        activeCharacter = !activeCharacter;
    }
}