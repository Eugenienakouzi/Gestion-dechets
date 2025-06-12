using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InteractionText : MonoBehaviour
{
    public TextMeshPro textMesh;

    private XRGrabInteractable grabInteractable;

    private void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();

        grabInteractable.selectEntered.AddListener(OnGrab);
        grabInteractable.selectExited.AddListener(OnRelease);

        if (textMesh != null)
            textMesh.text = "";
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        if (textMesh == null) return;

        switch (gameObject.tag)
        {
            case "Emballage":
                textMesh.text = "Emballage";
                break;
            case "Verre":
                textMesh.text = "Verre";
                break;
            case "Alimentaire":
                textMesh.text = "Alimentaire";
                break;
            default:
                textMesh.text = "Objet inconnu";
                break;
        }
    }

    private void OnRelease(SelectExitEventArgs args)
    {
        if (textMesh != null)
            textMesh.text = "";
    }
}
