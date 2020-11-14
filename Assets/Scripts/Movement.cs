using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float rotationSpeed;
    [SerializeField] ForceMode2D movementForceMode = ForceMode2D.Force;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 direction, float rotation)
    {
        Vector2 forward = transform.up;
        Vector2 right = transform.right;
        _rigidbody.AddForce(forward * direction.y + right * direction.x, movementForceMode);
        transform.Rotate(Vector3.back, rotation * rotationSpeed * Time.fixedDeltaTime);
    }
}
