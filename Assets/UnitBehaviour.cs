using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class UnitBehaviour : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void KillBad()
    {
        Debug.Log($"KillBad {gameObject.GetComponent<NetworkIdentity>().netId}");
        NetworkServer.Destroy(gameObject);
    }
    
    public void KillGood()
    {
        Debug.Log($"KillGood {gameObject.GetComponent<NetworkIdentity>().netId}");
        Destroy(gameObject);
    }
    
    public override void OnNetworkDestroy()
    {
        Debug.Log($"OnNetworkDestroy {gameObject.GetComponent<NetworkIdentity>().netId}");
    }
}
