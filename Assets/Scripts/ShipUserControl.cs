using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Movement))]
public class ShipUserControl : MonoBehaviour
{
    private Movement movement;
    private Shooting shooting;
    private Vector2 movementDirection;
    private float turningDirection;
    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<Movement>();
        shooting = GetComponent<Shooting>();
        movementDirection = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        float movementInput = 0;
#if UNITY_EDITOR
        movementInput = Mathf.Clamp(Input.GetAxisRaw("Vertical"), 0, 1);
        turningDirection = Input.GetAxisRaw("Horizontal");
        movementDirection = new Vector2(0, movementInput);

        if (Input.GetButtonDown("Fire1"))
        {
            shooting.shoot(transform.up);
        }
#endif
#if UNITY_ANDROID
        movementInput = Mathf.Clamp(TouchUserInput.Vertical, 0, 1);
        turningDirection = TouchUserInput.Horizontal;
        movementDirection = new Vector2(0, movementInput);

        if (TouchUserInput.Fire)
        {
            shooting.shoot(transform.up);
        }
#endif
    }


    private void FixedUpdate()
    {
        movement.Move(movementDirection, turningDirection);
    }
}
