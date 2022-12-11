using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEatMass : MonoBehaviour
{
    [SerializeField] private GameObject[] mass;
        
    private void Start()
    {
        UpdateMass();
        InvokeRepeating("CheckMass", 0, 0.1f);
    }

    public void PlayerEat()
    {
        transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
    }

    public void UpdateMass()
    {
        mass = GameObject.FindGameObjectsWithTag("Mass");
    }

    public void AddMass(GameObject massObject)
    {
        List<GameObject> massList = new List<GameObject>();
        for (int i = 0; i < mass.Length; i++)
        {
            massList.Add(mass[i]);
        }
        massList.Add(massObject);
        mass = massList.ToArray();
    }

    public void RemoveMass(GameObject massObject)
    {
        List<GameObject> massList = new List<GameObject>();
        for (int i = 0; i < mass.Length; i++)
        {
            massList.Add(mass[i]);
        }
        massList.Remove(massObject);
        mass = massList.ToArray();
    }

    public void CheckMass()
    {
        for (int i = 0; i < mass.Length; i++)
        {
            Transform m = mass[i].transform;
            if (Vector2.Distance(transform.position, m.position) <= transform.localScale.x / 2)
            {
                RemoveMass(m.gameObject);
                //eat
                PlayerEat();
                //destroy mass
                Destroy(m.gameObject);
            }
        }
    }
}
