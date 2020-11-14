using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossEdge : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2((transform.position.x + 10) % 10, (transform.position.y + 10) % 10);
    }
}
