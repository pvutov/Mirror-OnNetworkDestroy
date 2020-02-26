using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class UnitSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefab = null;
    private GameObject _lastSpawned;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Press 's' to spawn a unit, 'd' to destroy it with NetworkServer.Destroy() which causes the callback to be called twice, 'f' to use a plain Unity Destroy which only invokes the callback once.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            _lastSpawned = Instantiate(_prefab);
            NetworkServer.Spawn(_lastSpawned);
        }
        else if (Input.GetKeyDown("d"))
        {
            _lastSpawned.GetComponent<UnitBehaviour>().KillBad();
        }
        else if (Input.GetKeyDown("f"))
        {
            _lastSpawned.GetComponent<UnitBehaviour>().KillGood();
        }
    }
}
