using UnityEngine;

public class Embalage : MonoBehaviour
{
    public int score = 0;

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
    }
}
