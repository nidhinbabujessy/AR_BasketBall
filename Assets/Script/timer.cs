using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float time = 60; // Start the timer at 60 seconds
    public TextMeshProUGUI TimerText;

    public GameObject winningPannel;
    bool startTime;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        startTime = false;
    }

    public void startT()
    {
        startTime = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (startTime == true)
        {
            // Decrease time by deltaTime every frame (which is roughly 1 second)
            time -= Time.deltaTime;

            // Ensure that time doesn't go below 0
            time = Mathf.Max(time, 0);

            // Update the timer text
            TimerText.text = Mathf.CeilToInt(time).ToString(); // Round to nearest second and convert to string

            if (time <= 0)
            {
                // Timer has reached 0, perform your action here
                // For example, you can trigger an event or execute some code
                winningPannel.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }//
}
