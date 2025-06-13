using System;
using TMPro;
using UnityEngine;

public class Embalage : MonoBehaviour
{
    public int score = 0;
    public TextMeshPro scoreText;
    public GameObject cylindre;
    public GameObject cylindreV;
    public GameObject cylindreR;
    
    public float timer = 0f;
    public bool actionFait = false;
    
    
    private void Update()
    {
        scoreText.text = "" + score;
        
        if (!actionFait)
        {
            timer += Time.deltaTime;

            if (timer >= 2f)
            {
                cylindreV.SetActive(false);
                cylindreR.SetActive(false);
                cylindre.SetActive(true);
                
                timer = 0f;
                actionFait = true;
            }
        }
    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(this.tag))
        {
            score++;
            cylindre.SetActive(false);
            cylindreV.SetActive(true);
            actionFait = false;
            Destroy(other.gameObject);
        }
        else if (!other.CompareTag("Untagged"))
        {
            score--;
            cylindre.SetActive(false);
            cylindreR.SetActive(true);
            actionFait = false;
            Destroy(other.gameObject);
        }
    }
}
