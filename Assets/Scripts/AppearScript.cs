using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearScript : MonoBehaviour
{
    public float[] playerposition_x;
    [SerializeField] private GameObject[] foreverchaseObjects;
    [SerializeField] private GameObject player;
    private int objectNumber=0;

    // Start is called before the first frame update
    void Start()
    {
        foreach ( var foreverchaseObject in foreverchaseObjects)
        {
            foreverchaseObject.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x>=playerposition_x[objectNumber] && objectNumber != foreverchaseObjects.Length - 1)
        {
            foreverchaseObjects[objectNumber].SetActive(true);
            objectNumber +=1;
        }
        else if(player.transform.position.x>=playerposition_x[objectNumber])
        {
            foreverchaseObjects[objectNumber].SetActive(true);
        }
    }
    public void Disappear()
    {
        foreach ( var foreverchaseObject in foreverchaseObjects)
        {
            foreverchaseObject.SetActive(false);
            int i=0;
            Debug.Log(i);
            i+=1;
        }
    }
}
