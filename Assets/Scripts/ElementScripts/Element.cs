using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Element", menuName = "Elements/Element")]

public class Element : ScriptableObject
{
    public float waterPortion;
    public float earthPortion;
    public float airPortion;
    public float firePortion;

    public bool hasLife;
    public bool isFireable;
    public bool isLiquid;
    public bool isSolid;
    public bool isGas;

    public float solidity;
    public float sharpness;
    public float magic;
    public float protection;

    public string name;

    public Color color;

    public void Init(float water, float earth, float air, float fire, Color coloration, string thisname)
    {
        waterPortion = water;
        earthPortion = earth;
        airPortion = air;
        firePortion = fire;

        color = new Color(coloration.r, coloration.g, coloration.b, 1);
        name = thisname;

        Debug.Log(waterPortion + " " + earthPortion + " " + airPortion + " " + firePortion +" " +name);
    }

}
