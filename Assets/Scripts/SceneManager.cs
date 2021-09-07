using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

using Hashtable = ExitGames.Client.Photon.Hashtable;

public class SceneManager : MonoBehaviour
{
    private PhotonView pv;
    private Hashtable CP;
    // Start is called before the first frame update
    void Start()
    {
        pv = GetComponent<PhotonView>();
        CP = PhotonNetwork.LocalPlayer.CustomProperties;


        GameObject playerTemp = PhotonNetwork.Instantiate("Player", Vector3.one, Quaternion.identity, 0);
        int colorIdx = (int)CP["Color"];
        playerTemp.GetComponent<Sphere>().SetColor(colorIdx);
        

        Debug.Log($"custon property : {CP["Color"]}");
        Debug.Log("dhkdnwk" + CP["Color"]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
