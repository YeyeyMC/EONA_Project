using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class ExplodedView : MonoBehaviour
{
    [Header("Configuración de explosión")]
    [Tooltip("Distancia vertical entre capas")]
    [SerializeField] private float spacing = 0.5f;

    // Estas dos listas se llenan en Awake()
    private List<Transform> parts = new List<Transform>();
    private Vector3[] originalPos, explodedPos;

    private void Awake()
    {
        // 1) Recoge todos los hijos directos como 'partes'
        for (int i = 0; i < transform.childCount; i++)
            parts.Add(transform.GetChild(i));

        int n = parts.Count;
        originalPos = new Vector3[n];
        explodedPos = new Vector3[n];

        // 2) Guarda posiciones originales y calcula posiciones explosionadas
        for (int i = 0; i < n; i++)
        {
            originalPos[i] = parts[i].localPosition;
            // ejemplo: cada parte sube spacing*(i+1) unidades en Y
            explodedPos[i] = originalPos[i] + Vector3.up * spacing * (i + 1);
        }
    }

    /// <summary>
    /// t = 0 → estado original.  
    /// t = 1 → completamente explosionado.
    /// </summary>
    public void SetExplosion(float t)
    {
        for (int i = 0; i < parts.Count; i++)
        {
            parts[i].localPosition =
                Vector3.Lerp(originalPos[i], explodedPos[i], Mathf.Clamp01(t));
        }
    }

    // Opcional: animar con botón
    public void ToggleExplosion()
    {
        StopAllCoroutines();
        float target = parts[0].localPosition == originalPos[0] ? 1f : 0f;
        StartCoroutine(AnimateExplosion(target, 0.5f));
    }

    private IEnumerator AnimateExplosion(float target, float duration)
    {
        // Detecta factor actual tomando la primera parte
        float start = (parts[0].localPosition.y - originalPos[0].y) /
                      (explodedPos[0].y - originalPos[0].y);

        float elapsed = 0f;
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            float t = Mathf.SmoothStep(start, target, elapsed / duration);
            SetExplosion(t);
            yield return null;
        }
        SetExplosion(target);
    }
}
