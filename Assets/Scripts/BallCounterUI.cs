using UnityEngine;
using TMPro;  

public class BallCounterUI : MonoBehaviour
{
    public BallCollector ballCollector;      
    public TextMeshProUGUI ballCounterText;   

    void Start()
    {
        if (ballCounterText == null)
        {
            Debug.LogError("BallCounterText is not assigned!");
        }

        if (ballCollector == null)
        {
            Debug.LogError("BallCollector script reference is missing!");
        }
    }

    void Update()
    {
        if (ballCollector != null && ballCounterText != null)
        {
            ballCounterText.text = "Balls Collected: " + ballCollector.ballsCollected.ToString();
        }
    }
}
