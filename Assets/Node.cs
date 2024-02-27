using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{

    public bool walkabale;
    public Vector3 worldPosition;

    public Node(bool _walkabale, Vector3 _worldPosition)
    {
        walkabale = _walkabale;
        worldPosition = _worldPosition;
    }

}
