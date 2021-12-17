using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class halfway_trigger : MonoBehaviour
{
    public GameObject half_lap;
    public GameObject Lap_complete;
    void OnTriggerEnter () {
        Lap_complete.SetActive(true);
        half_lap.SetActive(false);
    }
}
