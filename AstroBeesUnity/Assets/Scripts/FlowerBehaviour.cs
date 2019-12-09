using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerBehaviour : MonoBehaviour
{
    private GameObject cc; //canvas holding traits

    private void Start()
    {
        cc = gameObject.transform.GetChild(0).gameObject;
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
