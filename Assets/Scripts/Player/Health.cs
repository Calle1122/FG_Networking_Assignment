using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class Health : NetworkBehaviour
{
    public NetworkVariable<int> currentHealth = new NetworkVariable<int>();
    public NetworkVariable<int> currentShield = new NetworkVariable<int>();


    public override void OnNetworkSpawn()
    {
        if(!IsServer) return;
        currentHealth.Value = 100;
        currentShield.Value = 0;
    }


    public void TakeDamage(int damage){
        if (currentShield.Value > 0)
        {
            currentShield.Value--;
            return;
        }
        
        damage = damage<0? damage:-damage;
        currentHealth.Value += damage;

        currentHealth.Value = Mathf.Clamp(currentHealth.Value, 0, 100);
    }

    public void Heal(int amount)
    {
        currentHealth.Value = Mathf.Clamp(currentHealth.Value + amount, 0, 100);
    }

}
