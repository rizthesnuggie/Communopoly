using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerposition : MonoBehaviour
{

    public Playerposition(string Name, int Spaces)
    {
        this.Name = Name;
        BoardPos = 0;
        Position = null;
        _Board = new Board() { Spaces = Spaces};
    }
    public string Name { get; set; }
    public int BoardPos { get; set; }
    public Vector3? Position { get; set; }
    public Board _Board { get; set; }

    public void AddPos(int Pos)
    {
        BoardPos += Coterminal(Pos);
    }
    public int Coterminal(int Pos)
    {
        if (Pos > _Board.Spaces) return Pos - _Board.Spaces;
        return Pos;
    }
}
public class Board
{
    public int Spaces { get; set; }
    public Vector2 Dimensions { get; set; }
}
