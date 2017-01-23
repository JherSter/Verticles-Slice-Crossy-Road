using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node {

    public GameObject Object;
    public bool IsWalkable;
    public void Reset()
    {
        IsWalkable = true;
        Object = null;
    }
}
