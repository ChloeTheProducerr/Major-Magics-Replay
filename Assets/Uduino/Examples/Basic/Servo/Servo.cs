using UnityEngine;
using System.Collections;
using Uduino;

public class Servo : MonoBehaviour
{
    public int servoPin = 1;
    [Range(0, 180)]
    public int servoAngle = 0;
    private int prevServoAngle = 0;

    void Start()
    {
        UduinoManager.Instance.pinMode(servoPin, PinMode.Servo);
    }

    void Update()
    {
        if (servoAngle != prevServoAngle) // Condition to not send data each frame 
        {
            UduinoManager.Instance.sendCommand("setServoAngle", servoPin, servoAngle);
            prevServoAngle = servoAngle;
        }
    }
}