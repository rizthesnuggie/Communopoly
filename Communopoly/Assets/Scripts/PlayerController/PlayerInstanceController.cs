using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInstanceController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PlayerContainer;
    PositionController GamePositionController;
    void Start()
    {
        GamePositionController = new PositionController(PlayerContainer.GetComponent<PlayerContainer>().Waypoints);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GamePositionController.AddPosition(1);
            transform.position = GamePositionController.Position;
        }
    }
}
