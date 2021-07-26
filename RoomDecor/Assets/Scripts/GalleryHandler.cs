using UnityEngine;
using UnityEngine.UI;
public class GalleryHandler : MonoBehaviour
{
    [SerializeField] private Transform imageContainer;

    internal Image[] galleryImages;

    private void Start()
    {
        galleryImages = Resources.LoadAll<Image>("GalleryImages");
        foreach (Image img in galleryImages)
        {
            Image image = Instantiate(img);
            image.transform.SetParent(imageContainer);
        }
    }
}
