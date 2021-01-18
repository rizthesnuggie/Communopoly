using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceController
{
    public int DiceCount { get; private set;}
    public void Roll()
    {
        DiceCount = Random.Range(0, 6);
    }
}
