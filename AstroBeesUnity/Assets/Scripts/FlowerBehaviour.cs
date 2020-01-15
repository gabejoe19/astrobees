using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerBehaviour : MonoBehaviour
{
    private GameObject cc; //canvas holding traits

    public string[,] colorTraits = new string[1,2];
    public string[,] stemTraits = new string[1, 2];
    public string[,] petalTraits = new string[1, 2];
    public string[,] thornsTraits = new string[1, 2];

    private void Start()
    {
        cc = gameObject.transform.GetChild(0).gameObject;
        colorTraits[0, 0] = "C";
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        cc.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        cc.SetActive(false);
    }
}
