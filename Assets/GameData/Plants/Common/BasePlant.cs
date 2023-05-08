using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum E_AllPlant
{
    None = 0,
    PeaShooter = 1,
    Max
}

public abstract class BasePlant : MonoBehaviour
{
    private void Start()
    {
        Init();
    }

    private void Update()
    {
        Tick();
    }

    protected abstract void Init();

    protected abstract void Tick();

    protected int GetInstanceID(E_AllPlant type)
    {
        return (int)type;
    }
}


