using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContainer : MonoBehaviour
{
    public GameObject Waypoints;
    public void Start()
    {
        Instantiate(Waypoints);
    }
}
