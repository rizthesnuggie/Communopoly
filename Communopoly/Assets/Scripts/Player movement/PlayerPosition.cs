using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Position
{
    public Vector3 _Position { get; private set; }
    public Position(Board Board, int StartPos)
    {
        _BoardPos = StartPos;
        _Board = Board;
        GetPosition();
    }
    PlayerPos[] Positions;
    int _BoardPos;
    Board _Board;

    public void AddPos(int Pos)
    {
        _BoardPos += Pos;
        _Position = Positions.Where(p => p.Space == Coterminal(_BoardPos)).First().Pos;
    }
    public int Coterminal(int Pos)
    {
        while(Pos >= _Board.Spaces)
        {
            Pos -= _Board.Spaces;
        }
        return Pos;
    }
    public void GetPosition()
    {
        List<PlayerPos> positions = new List<PlayerPos>();
        int SideTotal = _Board.Spaces / 4;
        for (int SideCount = 0; SideCount < SideTotal; SideCount++)
        {
            //set left and right sides
            positions.Add(new PlayerPos()
            {
                Space = SideTotal * 0 + SideCount,
                Pos = new Vector3()
                {
                    x = _Board.Position.x,
                    y = _Board.Position.y,
                    z = _Board.Position.z + (SideCount * _Board.Dimensions.y)
                }
            });
            positions.Add(new PlayerPos()
            {
                Space = SideTotal*1 + SideCount,
                Pos = new Vector3()
                {
                    x = _Board.Position.x + _Board.Dimensions.x,
                    y = _Board.Position.y,
                    z = (_Board.Position.z + _Board.Dimensions.y) - (SideCount * _Board.Dimensions.y)
                }
            });
            //set top and bottom sides
            positions.Add(new PlayerPos()
            {
                Space = SideTotal*2 + SideCount,
                Pos = new Vector3()
                {
                    x = _Board.Position.x + (SideCount * _Board.Dimensions.x),
                    y = _Board.Position.y,
                    z = _Board.Position.z + _Board.Dimensions.y
                }
            });
            positions.Add(new PlayerPos()
            {
                Space = SideTotal*3 + SideCount,
                Pos = new Vector3()
                {
                    x = (_Board.Position.x + _Board.Dimensions.x) - (SideCount * _Board.Dimensions.x),
                    y = _Board.Position.y,
                    z = _Board.Position.z
                }
            });
        }
        Positions = positions.ToArray();
    }
}
public class PlayerPos
{
    public int Space { get; set; }
    public Vector3 Pos { get; set; }
}
public class Board
{
    public Board(int Spaces, Vector2 Dimensions, Vector3 BottomLeftCornerPos)
    {
        this.Dimensions = Dimensions;
        this.Spaces = Spaces;
        Position = BottomLeftCornerPos;
    }
    public int Spaces { get; set;  }
    public Vector2 Dimensions { get; set; }
    public Vector3 Position { get; set; }
}
