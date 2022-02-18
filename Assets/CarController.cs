using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CarController : MonoBehaviour {

    public float fuel = 1;
    public float fuelconsumption = 0.1f;
    public Rigidbody2D carRigidBody;
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public float speed;
    public float carTorque = 10;
    private float movement;
    public UnityEngine.UI.Image image;

    void Start() {
        
    }

    void Update() {
        movement = CrossPlatformInputManager.GetAxis("Horizontal");
        image.fillAmount = fuel;
    }

    private void FixedUpdate()
    {

        if(fuel>0)
        {
            backTire.AddTorque(movement * speed * Time.fixedDeltaTime);
            frontTire.AddTorque(movement * speed * Time.fixedDeltaTime);
            carRigidBody.AddTorque(-movement * carTorque * Time.fixedDeltaTime);
        }

        if (speed > 200)
            speed = 200;

        fuel -= fuelconsumption * Mathf.Abs(movement) * Time.fixedDeltaTime;
    }

}
