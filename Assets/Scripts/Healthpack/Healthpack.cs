using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class Healthpack : NetworkBehaviour
{
    
    void OnTriggerEnter2D(Collider2D other)
    {

    
        if(IsServer){

            Health health = other.GetComponent<Health>();
            if(!health) return;
            health.Heal(25);

            NetworkObject networkObject = gameObject.GetComponent<NetworkObject>();
            networkObject.Despawn();
        }


    }




}
