using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleports : MonoBehaviour
{

    public GameObject Krueger;
    public int Loc;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Krueger.transform.position = new Vector3(5, 1, 0);
            Loc++;
            Debug.Log(Loc);
        }
    }
}
