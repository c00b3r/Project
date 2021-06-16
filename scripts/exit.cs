using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exit : MonoBehaviour
{
    [SerializeField] private GameObject tutorial;
    [SerializeField] private GameObject inventory;
    [SerializeField] private GameObject craft;
    [SerializeField] private GameObject sborinfo;
    [SerializeField] private GameObject malinainfo;
    [SerializeField] private GameObject dontsborinfo;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            tutorial.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            inventory.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            inventory.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            craft.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            craft.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            sborinfo.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            sborinfo.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            malinainfo.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            malinainfo.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            dontsborinfo.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            dontsborinfo.SetActive(false);
        }
    }
}
