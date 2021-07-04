using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour, IIntertactable
{
    private Renderer rnd;
    private void Awake()
    {
        rnd = GetComponent<Renderer>();
    }
    public void Intrect()
    {
        rnd.material = Palette.Instance.GetMaterial();
    }
}
