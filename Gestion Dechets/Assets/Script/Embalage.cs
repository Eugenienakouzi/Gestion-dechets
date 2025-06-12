using TMPro;
using UnityEngine;

public class Embalage : MonoBehaviour
{
    public int score = 0;
    public TextMeshPro scoreText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(this.tag))
        {
            score++;
        }
        else if (!other.CompareTag("Untagged"))
        {
            score--;
        }
        scoreText.text = "" + score;
    }
}
