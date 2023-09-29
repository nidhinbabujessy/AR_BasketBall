using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManagement : MonoBehaviour
{
    [SerializeField]  TextMeshProUGUI scoreText;
    // Start is called before the first frame update


    private float score = 0;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
    public void scoree()
    {
        score = score + 1;
    }
}
