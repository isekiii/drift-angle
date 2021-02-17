using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PointSystem : MonoBehaviour
{


    public Rigidbody car;

    public float currentScore;
    public float totalScore;

    public bool isDrifting = false;

    public float driftAngle;

    public Speedometer speedometer;

    public TMP_Text currentText, totalText;


    void Update()
    {
       driftAngle = Vector3.Angle(car.velocity, car.transform.forward);
       
        isDrifting = driftAngle > 15;
        
        UpdateScore();
        UpdateText();
    }

    void UpdateScore()
    {
        if (isDrifting)
        {
            currentScore += driftAngle * speedometer.vehicleSpeed;
        }
        else
        {
            totalScore += currentScore;
            currentScore = 0;
        }
    }

    void UpdateText()
    {
        if (currentScore > 0)
        {
            currentText.text = currentScore.ToString();
        }
        else currentText.text = "";

        totalText.text ="Total score: " +  totalScore.ToString();
    }
}
