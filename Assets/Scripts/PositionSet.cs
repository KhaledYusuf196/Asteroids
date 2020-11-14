using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSet : MonoBehaviour
{
    [SerializeField] Vector2 position;
    private Rigidbody2D _rigidbody;

    public void ResetPosition()
    {
        transform.position = position;
    }

    public void ResetVelocity()
    {
        if(_rigidbody = GetComponent<Rigidbody2D>())
            _rigidbody.velocity = Vector2.zero;
    }

    public void ResetRotation()
    {
        transform.rotation = Quaternion.identity;
    }
}
