using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyDamage : MonoBehaviour
{
    [SerializeField] LayerMask shootableLayers;

    private void OnTriggerEnter2D(Collider2D other)
    {
        int shootedlayerMask = 1 << other.gameObject.layer;
        print((int)shootableLayers + " " + shootedlayerMask);
        if ((shootableLayers & shootedlayerMask) != 0)
        {
            other.GetComponent<Health>().takeDamage();
            Destroy(gameObject);
        }
    }
}
