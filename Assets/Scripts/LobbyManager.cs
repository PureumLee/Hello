using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using Hashtable = ExitGames.Client.Photon.Hashtable;


public class LobbyManager : MonoBehaviour
{
    private PhotonView pv;
    private Hashtable CP;

    // Start is called before the first frame update
    void Start()
    {
        pv = GetComponent<PhotonView>();
        CP = PhotonNetwork.LocalPlayer.CustomProperties;
        
        CP["Color"] = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetColorProperty(int num)
    {
        CP["Color"] = num;
    }

}
