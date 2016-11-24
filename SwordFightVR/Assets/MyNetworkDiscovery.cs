using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MyNetworkDiscovery : NetworkDiscovery {

    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public override void OnReceivedBroadcast(string fromAddress, string data)
    {
        base.OnReceivedBroadcast(fromAddress, data);
        // NetworkManager.singleton.
    }
}
