using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{



    private bool cube1 = false;
    private scoreManagement ScoreManger;
   
    void Start()
    {
        ScoreManger = FindObjectOfType<scoreManagement>();
        //  ScoreManger= GetComponent<scoreManagement>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider has both "ring1" and "ring2" tags
        if (other.CompareTag("ring1") )
        {
            print("collides 1");
            cube1=true;
           
        }
        if (other.CompareTag("ring2")&&cube1==true)
        {
            print("collides 2");
            // implment delegate=====================================
            ScoreManger.scoree();
            cube1 = false;
        }
    }

    void Update()
    {
        // Convert the score to a string before assigning it to the text
       
    }
}
