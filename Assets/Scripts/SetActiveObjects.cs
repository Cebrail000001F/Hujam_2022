using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveObjects : MonoBehaviour
{
    [SerializeField] private GameObject[] planets;
    private void Moon()
    {
        if (gameObject.transform.localScale.x == 10f && gameObject.transform.localScale.y == 10f)
            planets[0].SetActive(true);
        else
        {
            planets[1].SetActive(false);
            planets[2].SetActive(false);
        }
    }
    private void Earth()
    {
        if (gameObject.transform.localScale.x == 20f && gameObject.transform.localScale.y == 20f)
            planets[1].SetActive(true);
        else
        {
            planets[0].SetActive(false);
            planets[2].SetActive(false);
        }
    }
    private void GasGaint()
    {
        if (gameObject.transform.localScale.x == 30f && gameObject.transform.localScale.y == 30f)
            planets[2].SetActive(true);
        else
        {
            planets[0].SetActive(false);
            planets[1].SetActive(false);
        }
    }
}
