using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instatiator : MonoBehaviour
{
    public GameObject[] comidas;
    int derecha = 17;
    int izq = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Instantiate();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Instantiate1();
        }
    }
    
    public void Instantiate()
    {
       
            DeactivateAll();
            comidas[izq].SetActive(true);
            izq++;
        if (izq == 17)
        {
            izq = 0;
        }

    }
    public void Instantiate1()
    {

        DeactivateAll();
        comidas[derecha].SetActive(true);
        derecha--;
        if (derecha == 0)
        {
            derecha = 17;
        }

    }
    public void DeactivateAll()
    {
        for (int i = 0; i < comidas.Length; i++)
        {
            comidas[i].SetActive(false);
        }
    }
}

