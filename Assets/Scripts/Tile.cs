using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour, IInteractable
{
    private Renderer rnd;
    private void Awake()
    {
        rnd = GetComponent<Renderer>();
    }
    public void Interact()
    {
        rnd.material = Palette.Instance.GetMaterial();
    }
}
