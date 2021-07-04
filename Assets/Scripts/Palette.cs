using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Palette : MonoBehaviour
{
    private static Palette instance;

    private int materialNumber = 0;
    private Material currentMaterial;
    private Renderer rnd;

    public List<Material> materialList;

    public UnityAction OnSetMaterial;

    public static Palette Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<Palette>();
            return instance;
        }
    }

    private void Awake()
    {
        rnd = GetComponent<Renderer>();
    }
    private void Start()
    {
        SetMaterial(materialList[0]);
    }
    public Material GetMaterial()
    {
        return currentMaterial;
    }
    public Material GetNextMaterial()
    {
        var temp = materialNumber + 1;
        if (temp == materialList.Count)
        {
            temp = 0;
        }
        return materialList[temp];
    }
    public Material GetLastMaterial()
    {
        var temp = materialNumber - 1;
        if (temp < 0)
        {
            temp = materialList.Count - 1;
        }
        return materialList[temp];
    }

    private void SetMaterial(Material mat)
    {
        rnd.material = mat;
        currentMaterial = mat;
        OnSetMaterial?.Invoke();
    }
    public void NextColor()
    {
        materialNumber++;

        if (materialNumber == materialList.Count)
        {
            materialNumber = 0;
        }
        SetMaterial(materialList[materialNumber]);
    }
    public void LastColor()
    {
        materialNumber--;

        if (materialNumber < 0)
        {
            materialNumber = materialList.Count - 1;
        }
        SetMaterial(materialList[materialNumber]);
    }
}
