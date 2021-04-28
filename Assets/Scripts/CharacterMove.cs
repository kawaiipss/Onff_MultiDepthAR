using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;
using GoogleARCore.Examples.CloudAnchors;
using UnityEngine.Networking;
using UnityEngine.UI;
using TMPro;

public class CharacterMove : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    private Vector3 velocityVector = Vector3.zero;

    public float maxVelocityChange = 4f;
    private Rigidbody rb;

    public float tiltAmount = 10f;

    //public NetworkInstanceId _objID;
    public TextMeshProUGUI _tmScore;
    private int _score = 100;
    public Transform _firePos;

    private Vector3 _direction;

    private Transform _charTransform;
    private Vector3 currPos;
    private Quaternion currRot;

    private float _xMovementInput;
    private float _zMovementInput;
    private Vector3 _movementHorizontal;
    private Vector3 _movementVertical;
    private Vector3 _movementVelocityVector;

    private Vector3 velocity;
    private Vector3 velocityChange;

    //public TextMeshProUGUI tmMsg;
    //private int attackCount;

    //private void Awake()
    //{
    //    tmMsg.text = "Hits: " + attackCount.ToString();
    //}

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        //if(variableJoystick == null)
        //{
        //    variableJoystick = GameObject.FindWithTag("Joystick").GetComponent<VariableJoystick>();
        //}
        //if(caControl == null)
        //{
        //    caControl = GameObject.FindWithTag("caControl").GetComponent<CloudAnchorsExampleController>();
        //}
        //else
        //{
        //    caControl._player = gameObject;
        //    caControl._firePos = _firePos;
        //}
        _tmScore.text = "100";
    }

    private void Update()
    {
        //_xMovementInput = variableJoystick.Horizontal;
        //_zMovementInput = variableJoystick.Vertical;

        //_movementHorizontal = transform.right * _xMovementInput;
        //_movementVertical = transform.forward * _zMovementInput;

        //_movementVelocityVector = (_movementHorizontal + _movementVertical).normalized * speed;

        //Move(_movementVelocityVector);

        //transform.rotation = Quaternion.Euler(variableJoystick.Vertical * speed * tiltAmount, 0, -1 * variableJoystick.Horizontal * speed * tiltAmount);

        _direction = Vector3.right * variableJoystick.Horizontal + Vector3.forward * variableJoystick.Vertical;
        //rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        gameObject.transform.Translate(_direction * 0.01f);
        _charTransform = gameObject.transform;
    }


    void Move(Vector3 movementVelocityVector)
    {
        velocityVector = movementVelocityVector;
    }

    //public void OnTriggerEnter(Collider other)
    //{
    //    attackCount++;
    //    tmMsg.text = "Hits: " + attackCount.ToString();
    //}

    //public void OnCollisionEnter(Collision collision)
    //{
    //    attackCount++;
    //    tmMsg.text = "Hits: " + attackCount.ToString();
    //}

    public void FixedUpdate()
    {
        //if (!photonView.IsMine)
        //{
        //    _direction = Vector3.right * variableJoystick.Horizontal + Vector3.forward * variableJoystick.Vertical;
        //    gameObject.transform.Translate(_direction * (1.0f / PhotonNetwork.SerializationRate) * speed);
        //    //rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        //    //_charTransform = gameObject.transform;
        //    //print("방향: " + direction.ToString());
        //    rb.position = Vector3.MoveTowards(rb.position, networkedPos, distance * (1.0f / PhotonNetwork.SerializationRate));
        //    rb.rotation = Quaternion.RotateTowards(rb.rotation, networkedRot, angle * (1.0f / PhotonNetwork.SerializationRate));
        //}

        //_direction = Vector3.right * variableJoystick.Horizontal + Vector3.forward * variableJoystick.Vertical;
        ////rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        //gameObject.transform.Translate(_direction * 0.01f);
        //_charTransform = gameObject.transform;
        //print("방향: " + direction.ToString());

        //if (velocityVector != Vector3.zero)
        //{
        //    velocity = rb.velocity;
        //    velocityChange = (velocityVector - velocity);

        //    velocityChange.x = Mathf.Clamp(velocityChange.x, -maxVelocityChange, maxVelocityChange);
        //    velocityChange.z = Mathf.Clamp(velocityChange.z, -maxVelocityChange, maxVelocityChange);
        //    velocityChange.y = 0f;

        //    rb.AddForce(velocityChange, ForceMode.Acceleration);
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullet"))
        {
            _score -= 10;
            _tmScore.text = _score.ToString();
        }
    }

    //public void OnClickFire()
    //{
    //    Instantiate(_bullet, _firePos.position, _firePos.rotation);
    //}

    //IEnumerator MoveCharacter()
    //{
    //    yield return null;
    //    Vector3 direction = Vector3.right * variableJoystick.Vertical * -1 + Vector3.forward * variableJoystick.Horizontal;
    //    //rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    //    gameObject.transform.Translate(direction * 0.01f);
    //    //print("방향: " + direction.ToString());
    //}
}
