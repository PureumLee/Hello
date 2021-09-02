using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public bool isConnect = false;
    public Transform[] spawnPoints;

    public int idxMt = 0;
    public Material[] mtList;

    private Renderer player;

    // public int[] tempList = {7, 8, 9};

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }
    }   

    void Start()
    {
        // StartCoroutine(CreatePlayer());
        // Debug.Log($"tempList[idxMt] : {tempList[idxMt]}");
        player = GameObject.Find("Player").GetComponent<Renderer>();
        SetMt(0);
        
    }

    void Update()
    {
        //ex
    }

    IEnumerator CreatePlayer()
    {
        yield return new WaitUntil(() => isConnect);

        // spawnPoints = GameObject.Find("SpawnPointGroup").GetComponentsInChildren<Transform>();

        // Vector3 pos = spawnPoints[PhotonNetwork.CurrentRoom.PlayerCount].position;
        // Quaternion rot = spawnPoints[PhotonNetwork.CurrentRoom.PlayerCount].rotation;

        // GameObject playerTemp = PhotonNetwork.Instantiate("Player", pos, rot, 0);
    }

    public void SetMt(int idx)
    {
        idxMt = idx;
        player.material = mtList[idxMt];
    }
}