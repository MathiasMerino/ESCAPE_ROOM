using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [Header("Configuración")]
    public float interactionDistance = 3f;
    public Camera playerCamera;
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
        if (playerCamera == null)
        {
            Debug.LogWarning("Asigna la cámara del jugador.");
            return;
        }

        Ray ray = new Ray(
            playerCamera.transform.position,
            playerCamera.transform.forward
        );

        if (Physics.Raycast(ray, out RaycastHit hit, interactionDistance))
        {
            Debug.Log("Objeto detectado: " + hit.collider.name);

            hit.collider.SendMessage(
                "OnInteract",
                SendMessageOptions.DontRequireReceiver
            );
        }
    }
}