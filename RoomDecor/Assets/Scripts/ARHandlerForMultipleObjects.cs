using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit.AR;
public class ARHandlerForMultipleObjects : MonoBehaviour
{
   
    [SerializeField] private ARPlacementInteractable placementInteractable;

    [SerializeField] private GameObject buttonPrefab;

    [SerializeField] private Transform content;//ButtonContainer

    [SerializeField] private Text itemName;

    [SerializeField] private Text itemDescription;

    [SerializeField] private RawImage itemImage;

    private GameObject button;

    private Items[] items;

   
    
    private void Start()
    {
        items = Resources.LoadAll<Items>("Items");
        foreach (Items item in items)
        {
            button = Instantiate(buttonPrefab);
            button.transform.SetParent(content);
            button.GetComponentInChildren<RawImage>().texture = item.ItemImage;
            button.GetComponent<Button>().onClick.AddListener(() => SwapModelAndInfo(item.ItemModel, item.ItemName, item.ItemDescription, item.ItemImage));
        }
    }
   
    public void AfterObjectPlacement()
    {
        placementInteractable.placementPrefab = null;
    }
    public void SwapModelAndInfo(GameObject model, string name, string desciption, Texture image)
    {       
        //Debug.Log(name);
        placementInteractable.placementPrefab = model;
        itemName.text = name;
        itemDescription.text = desciption;
        itemImage.texture = image;
    }
}
