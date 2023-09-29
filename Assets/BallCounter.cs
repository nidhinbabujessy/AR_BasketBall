using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCounter : MonoBehaviour
{
    private float time = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if (time <= 0)
        {
            // Perform an action when the timer reaches zero
            Destroy(gameObject); // Destroy the GameObject this script is attached to
        }
    }
}
