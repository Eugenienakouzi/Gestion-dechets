using UnityEngine;

public class RadialLayout : MonoBehaviour
{
    public float radius = 100f; // Distance du centre
    void Start()
    {
        ArrangeButtons();
    }

    void ArrangeButtons()
    {
        int count = transform.childCount;
        float angleStep = 360f / count;

        for (int i = 0; i < count; i++)
        {
            Transform child = transform.GetChild(i);
            float angle = i * angleStep * Mathf.Deg2Rad;

            Vector2 pos = new Vector2(
                Mathf.Cos(angle) * radius,
                Mathf.Sin(angle) * radius
            );

            RectTransform rt = child.GetComponent<RectTransform>();
            rt.anchoredPosition = pos;
        }
    }
}