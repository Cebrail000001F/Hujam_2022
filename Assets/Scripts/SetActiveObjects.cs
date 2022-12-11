using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveObjects : MonoBehaviour
{
    [SerializeField] private GameObject[] planets;
    

    private void Update()
    {

    }
    public void ChangesSprite()
    {
        if (gameObject.transform.lossyScale.x >= 3f && gameObject.transform.localScale.x <= 3.5f)
        {
            planets[0].SetActive(true);
            print("3f oldum");
            planets[1].SetActive(false);
            planets[2].SetActive(false);
            planets[3].SetActive(false);
            
        }

        if (gameObject.transform.localScale.x >= 3.5f)
        {
            planets[1].SetActive(true);
            planets[0].SetActive(false);
            planets[2].SetActive(false);
        }

        if (gameObject.transform.localScale.x >= 10f && gameObject.transform.localScale.x <= 5f)
        {
            planets[2].SetActive(true);
          
            planets[1].SetActive(false);
        }

    }
    public void Moon()
    {

    }
    public void Earth()
    {

    }
    public void GasGaint()
    {

    }
}
