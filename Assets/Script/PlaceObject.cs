using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObject : MonoBehaviour
{
    private placeIndicator PlaceIndicator;
    public GameObject objectToPlace;

    public GameObject topButton;
    public GameObject DownButton;
   public GameObject placeIndicator;
    public GameObject ThrowButton;

    private GameObject newPlacedObject;
    private Timer timerr;

    private void Start()
    {
        timerr=GetComponent<Timer>();   
        PlaceIndicator = FindObjectOfType<placeIndicator>();
       placeIndicator.SetActive(true);

    }
    public void ClickToPlace()
    {
        newPlacedObject = Instantiate(objectToPlace,PlaceIndicator.transform.position, Quaternion.Euler(0, 180, 0));
        topButton.SetActive(true);
        DownButton.SetActive(false);
       placeIndicator.SetActive(false);
        ThrowButton.SetActive(true) ;
        timerr.startT();
    }
    public void ButtonEnable()
    {
        topButton.SetActive(false);
        DownButton.SetActive(true);
       placeIndicator.SetActive(true);
        ThrowButton.SetActive(false);
    }
}

