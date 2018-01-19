﻿using UnityEngine;
using System.Collections;

public class Structure : MonoBehaviour
{
    public StructureType structureType;

    public Tile[] occupiedTiles;

    // Use this for initialization
    void Start()
    {
        GetComponent<MeshRenderer>().material.color = structureType.color;
        Debug.Log(structureType.name);
    }

}
