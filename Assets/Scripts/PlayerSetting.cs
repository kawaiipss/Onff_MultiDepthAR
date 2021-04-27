using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerSetting : MonoBehaviourPun
{
    // Start is called before the first frame update
    void Start()
    {
        if (photonView.IsMine)
        {
            transform.GetComponent<CharacterMove>().enabled = true;
            transform.GetComponent<CharacterMove>().variableJoystick.gameObject.SetActive(true);
        }
        else
        {
            transform.GetComponent<CharacterMove>().enabled = false;
            transform.GetComponent<CharacterMove>().variableJoystick.gameObject.SetActive(false);
        }
    }
}
