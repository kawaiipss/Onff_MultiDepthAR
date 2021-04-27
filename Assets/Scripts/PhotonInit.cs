using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
//using TMPro;

public class PhotonInit : MonoBehaviourPunCallbacks
{
    private string gameVersion = "1.0";
    public string userID = "Onffworld";
    public byte maxPlayer = 20;

    private void Awake()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    private void Start()
    {
        if(!PhotonNetwork.IsConnected)
        {
            PhotonNetwork.GameVersion = gameVersion;
            PhotonNetwork.LocalPlayer.NickName = userID;
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public override void OnConnected()
    {
        Debug.Log("Connected");
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinRandomRoom();
        Debug.Log("Connected to master");
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined!!");
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        PhotonNetwork.CreateRoom(null, new RoomOptions { MaxPlayers = maxPlayer });
        Debug.Log("Join failed");
    }
}
