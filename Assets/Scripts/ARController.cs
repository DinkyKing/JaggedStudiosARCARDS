using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARController : MonoBehaviour
{
    public GameObject hideCanvas;
    private ARTrackedImageManager arTrackedImageManager;

    private void Awake()
    {
        arTrackedImageManager = GetComponent<ARTrackedImageManager>();
    }

    private void OnEnable()
    {
        arTrackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    private void OnDisable()
    {
        arTrackedImageManager.trackedImagesChanged -= OnImageChanged;
    }

    public void OnImageChanged(ARTrackedImagesChangedEventArgs _args)
    {
        foreach (var addedImage in _args.added)
        {
            hideCanvas.SetActive(false);
        }
    }
}
