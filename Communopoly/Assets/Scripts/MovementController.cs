using System;
using System.Linq;
using UnityEngine;

public class MovementController
{
    public int BoardPosition { get; private set; }
    public Vector3 Position { get; private set; }

    Transform[] Waypoints;

    public MovementController(GameObject PositionContainer)
    {
        Waypoints = null;
        Waypoints = PositionContainer.GetComponentsInChildren<Transform>()/*.OrderBy(point => Convert.ToInt32(string.Join("", point.name.Where(c => char.IsDigit(c))))).ToArray()*/;
        Debug.Log(Waypoints.Length);
       // Debug.Log(string.Join("", "example (2)".Where(c => char.IsDigit(c))));
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
