using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 20;
    [SerializeField] float horsePower = 20;
    [SerializeField] float rpm;
    private const float turnSpeed = 45;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody playerRb;
    [SerializeField] int wheelsOnGround;


    [SerializeField] GameObject centerOfMass;
    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] TextMeshProUGUI rpmText;
    [SerializeField] List<WheelCollider> allWheels;

    private void Start()
    {
        playerRb=GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }
    void Update()
    {
        //Get Input from player
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        if (IsOnGround()&&GameManager.instance.isFinished==false)
        {
            //Move the vehicle forward
            //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            playerRb.AddRelativeForce(Vector3.forward * forwardInput * horsePower);
            //Turning the vehicle
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

            //print speed
            speed = Mathf.RoundToInt(playerRb.velocity.magnitude * 2.237f);
            speedometerText.SetText("Speed: " + speed + " mph");

            //print RPM
            rpm = Mathf.Round((speed % 30) * 40);
            rpmText.SetText("RPM: " + rpm);
        }
    }
    bool IsOnGround()
    {
        wheelsOnGround = 0;
        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }
        if (wheelsOnGround == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
