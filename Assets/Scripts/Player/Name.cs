using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Netcode;
using UnityEngine;

public class Name : NetworkBehaviour
{
    public NetworkVariable<FixedString64Bytes> playerName = new NetworkVariable<FixedString64Bytes>();
    
    public override void OnNetworkSpawn()
    {
        if(!IsServer) return;
        playerName.Value = SavedClientInformationManager.GetUserData(NetworkManager.LocalClientId).userName;
    }
}
