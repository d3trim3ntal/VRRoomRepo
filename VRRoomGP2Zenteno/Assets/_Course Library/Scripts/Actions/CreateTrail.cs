using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

/// <summary>
/// This script creates a trail at the location of a gameobject with a particular width and color.
/// </summary>

public class CreateTrail : MonoBehaviour
{
    public GameObject trailPrefab = null;
    public Transform spawnPoint = null;
    public Button saveButton = null;
    private List<GameObject> savedTrails = new List <GameObject>();

    private float width = 0.05f;
    private Color color = Color.white;

    private GameObject currentTrail = null;

    public void Start()
    {
        if (saveButton != null)
        {
            saveButton.onClick.AddListener(SaveCreate);
        }
    }

    public void StartTrail()
    {
        if (!currentTrail)
        {
            currentTrail = Instantiate(trailPrefab, transform.position, transform.rotation, transform);
            ApplySettings(currentTrail);
        }
    }

    private void ApplySettings(GameObject trailObject)
    {
        TrailRenderer trailRenderer = trailObject.GetComponent<TrailRenderer>();
        trailRenderer.widthMultiplier = width;
        trailRenderer.startColor = color;
        trailRenderer.endColor = color;
    }

    public void EndTrail()
    {
        if (currentTrail)
        {
            currentTrail.transform.parent = null;
            currentTrail = null;
        }
    }

    public void SetWidth(float value)
    {
        width = value;
    }

    public void SetColor(Color value)
    {
        color = value;
    }

    public void SaveCreate()
    {
        if (currentTrail)
        {
           GameObject savedTrail = Instantiate(currentTrail, spawnPoint.position, spawnPoint.rotation);
           savedTrail.transform.SetParent(spawnPoint);
           savedTrails.Add(savedTrail);
           savedTrail.transform.parent = null;
        }
    }
}
