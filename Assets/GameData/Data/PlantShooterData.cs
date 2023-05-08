using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlantsData", menuName = "SO/PlantsData")]
public class PlantShooterData : ScriptableObject
{
    public List<PlantUnit> Plants;
}

public enum E_PlantType
{
    Static,
    Movable,
    Creative,
    Consumable,
}

[Serializable]
public class PlantUnit
{
    public int ID;
    public string Name;
    public E_PlantType Type;
    public int Attack;
    public int Health;
    public float Distance;
    public float Interval;
}
