﻿using UnityEngine;

public class BreakableObject : MonoBehaviour
{
    [SerializeField] private GameObject main;
    [SerializeField] private GameObject broken;
    [SerializeField] private Orientation orientation;

    [HideInInspector] public bool isBroken;

    private void Start()
    {
        BoxCollider collider = main.GetComponent<BoxCollider>();

        orientation = (Orientation)Random.Range(0, 3);
        tag = "Breakable";
        switch (orientation)
        {
            case Orientation.Left:
                transform.position += new Vector3(-0.95f + collider.size.z / 2, 0, 0);
                transform.Rotate(new Vector3(0, -90, 0));
                break;
            case Orientation.Right:
                transform.position += new Vector3(0.95f - collider.size.z / 2, 0, 0);
                transform.Rotate(new Vector3(0, 90, 0));
                break;
            case Orientation.Center:
                int offsetDirection = Random.Range(-1, 2);
                transform.position += new Vector3(0.1f * offsetDirection, 0, 0);
                transform.Rotate(new Vector3(0, 180, 0));
                break;
        }
    }

    public void SwitchState()
    {
        broken.SetActive(!isBroken);
        main.SetActive(isBroken);
        isBroken = !isBroken;

        tag = isBroken ? "Fixable" : "Breakable";
    }
}
