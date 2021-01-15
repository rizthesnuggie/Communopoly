using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PositionController
{
    public int BoardPosition { get; set; }
    public Vector3 Position { get; private set; }


    Transform[] Waypoints;
    public PositionController(GameObject PositionContainer)
    {
        List<Transform> waypoints = PositionContainer.GetComponentsInChildren<Transform>().ToList();
        waypoints.RemoveAt(0);
        Waypoints = waypoints.ToArray();
        if (Waypoints == null) throw new UnassignedReferenceException();
    }
    public void AddPosition(int pos)
    {
        BoardPosition += pos;
        Coterminal();
        Position = Waypoints[BoardPosition].transform.position;
    }
    void Coterminal()
    {
        while (BoardPosition >= Waypoints.Length)
        {
            BoardPosition -= Waypoints.Length;
        }
    }
}
