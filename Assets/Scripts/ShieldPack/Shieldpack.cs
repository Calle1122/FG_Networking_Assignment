using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class Shieldpack : NetworkBehaviour
{
    
    void OnTriggerEnter2D(Collider2D other)
    {

        
        Health health = other.GetComponent<Health>();
        if(!health) return;
        health.currentShield.Value = 2;

        NetworkObject networkObject = gameObject.GetComponent<NetworkObject>();
        networkObject.Despawn();


    }
    
}
