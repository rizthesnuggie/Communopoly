using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KruegerMove : MonoBehaviour
{
    public int Dicey;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire3"))
        {
           Dicey = Random.Range(1, 7);
            Player.transform.Translate(Vector3.back * Dicey);
            Debug.Log(Dicey);
        }
    }
}
