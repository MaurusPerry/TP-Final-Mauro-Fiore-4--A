using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AplicationController : MonoBehaviour
{
    public GameObject[] Lista_Modelos3D;
    public int Indice_Modelos3D = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < Lista_Modelos3D.Length; i++)
        {
            Lista_Modelos3D[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && !Input.GetKeyDown(KeyCode.RightArrow))
        {
            Lista_Modelos3D[Indice_Modelos3D].SetActive(false);
            Indice_Modelos3D++;

            if (Indice_Modelos3D == Lista_Modelos3D.Length)
            {
                Indice_Modelos3D = 0;
            }

            Lista_Modelos3D[Indice_Modelos3D].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && !Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Lista_Modelos3D[Indice_Modelos3D].SetActive(false);
            Indice_Modelos3D--;

            if (Indice_Modelos3D == -1)
            {
                Indice_Modelos3D = Lista_Modelos3D.Length-1;
            }

            Lista_Modelos3D[Indice_Modelos3D].SetActive(true);           
        }
    }
}
