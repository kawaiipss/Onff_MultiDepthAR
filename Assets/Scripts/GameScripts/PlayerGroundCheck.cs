using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundCheck : MonoBehaviour
{
    PlayerController _playerController;

    private void Awake()
    {
        _playerController = GetComponent<PlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _playerController.gameObject)
            return;
        _playerController.SetGroundedState(false);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == _playerController.gameObject)
            return;
        _playerController.SetGroundedState(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == _playerController.gameObject)
            return;
        _playerController.SetGroundedState(true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == _playerController.gameObject)
            return;
        _playerController.SetGroundedState(true);
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == _playerController.gameObject)
            return;
        _playerController.SetGroundedState(false);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject == _playerController.gameObject)
            return;
        _playerController.SetGroundedState(true);
    }
}
