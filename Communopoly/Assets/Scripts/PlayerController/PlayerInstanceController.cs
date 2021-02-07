using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerInstanceController : MonoBehaviour
{
    public string Name { get; private set; }
    public int Space { get; private set; }

    Transform[] Waypoints;
    public void Instantiate(Transform[] Waypoints, string Name, int Start)
    {
        this.Space = Start;
        this.Name = Name;
        this.Waypoints = Waypoints;
        if (Waypoints == null) throw new UnassignedReferenceException("wtf man");
    }
    public void addSpace(int pos)
    {
        Space += pos;
        Coterminal();
        //do animation here or something
        transform.position = Waypoints[Space].transform.position;
    }
    void Coterminal()
    {
        while (Space >= Waypoints.Length)
        {
            Space -= Waypoints.Length;
        }
    }
}
