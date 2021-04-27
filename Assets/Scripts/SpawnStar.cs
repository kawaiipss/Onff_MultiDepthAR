using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using Photon.Pun;
using Photon.Realtime;

public class SpawnStar : MonoBehaviourPun
{
    private GameObject _player;

    public GameObject SceneCamera;
    public GameObject _spawnBtn;

    public float ForwardOffset = 0.25f;

    private void Start()
    {
        if(SceneCamera == null)
        {
            SceneCamera = Camera.main.gameObject;
        }
    }

    public void OnClickMasterSpawn()
    {
        if(PhotonNetwork.IsMasterClient)
        {
            Debug.Log("Master");
        }
    }

    public void OnClickSpawn()
    {
        if(_player == null)
        {
            _player = PhotonNetwork.Instantiate("Star", SceneCamera.transform.position + (SceneCamera.transform.forward * ForwardOffset),Quaternion.identity);
            _spawnBtn.SetActive(false);
        }
    }
}
