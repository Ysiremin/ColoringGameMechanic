using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    public bool isActive = false;
    private Camera camera;
    void Start()
    {
        camera = Camera.main;
    }

    void Update()
    {
        if (!isActive)
            return;


        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform.TryGetComponent(out IIntertactable ýntertactable))
                {
                    ýntertactable.Intrect();
                }
            }
        }
    }
}
