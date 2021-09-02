using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SceneManager : MonoBehaviour
{
    private int myMt;
    // Start is called before the first frame update
    void Start()
    {
        myMt = GameManager.instance.idxMt;
        GameObject playerTemp = PhotonNetwork.Instantiate("Player", Vector3.one, Quaternion.identity, 0);
        playerTemp.GetComponent<Renderer>().material=GameManager.instance.mtList[myMt];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
