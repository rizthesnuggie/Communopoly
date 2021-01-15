using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KruegerMove : MonoBehaviour
{
    public PositionController PlayerController;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
      //  PlayerController = new MovementController(Container);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire3"))
        {
         //   PlayerController.AddPosition(Random.Range(1,6));
         //   Debug.Log(PlayerController.BoardPosition);
         //   Player.transform.position = PlayerController.Position;
        }
    }
}
