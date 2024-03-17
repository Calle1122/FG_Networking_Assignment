using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class AmmoPack : NetworkBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {

        
        PlayerController pc = other.GetComponent<PlayerController>();
        if(!pc) return;
        pc.currentAmmo.Value = 10;

        NetworkObject networkObject = gameObject.GetComponent<NetworkObject>();
        networkObject.Despawn();


    }
    
}
