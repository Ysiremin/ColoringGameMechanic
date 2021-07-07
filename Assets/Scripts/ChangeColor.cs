using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour, IInteractable

{
    private Renderer rnd;
    public Type currentType = Type.Forward;
    private void Awake()
    {
        rnd = GetComponent<Renderer>();
        Palette.Instance.OnSetMaterial += OnSetMaterial;
    }
    public void Interact()
    {
        switch (currentType)
        {
            case Type.Forward:
                Palette.Instance.NextColor();
                break;
            case Type.Backward:
                Palette.Instance.LastColor();
                break;
            default:
                break;
        }
    }

    private void OnSetMaterial()
    {
        switch (currentType)
        {
            case Type.Forward:
                rnd.material = Palette.Instance.GetNextMaterial();
                break;
            case Type.Backward:
                rnd.material = Palette.Instance.GetLastMaterial();
                break;
            default:
                break;
        }
    }
    public enum Type
    {
        Forward,
        Backward
    }
}
