using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreFinal : MonoBehaviour
{
    public Embalage e1;
    public Embalage e2;
    public Embalage e3;
    public GameObject gm;
    
    void Update()
    {
        if (e1.score >= 10 || e2.score >= 10 || e3.score >= 10)
        {
            gm.SetActive(true);
        }
    }
}
