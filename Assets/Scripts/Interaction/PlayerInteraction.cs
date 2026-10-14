using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float interactionDistance = 3f;
    public KeyCode interactionKey = KeyCode.E;

    void Update()
    {
        if (Input.GetKeyDown(interactionKey))
        {
            Interact();
        }
    }

    void Interact()
    {
        Ray ray = new Ray(
            transform.position + Vector3.up * 0.5f,
            transform.forward
        );

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactionDistance))
        {
            InteractableObject obj =
                hit.collider.GetComponent<InteractableObject>();

            if (obj != null)
            {
                obj.Interact();
            }
        }
    }
}