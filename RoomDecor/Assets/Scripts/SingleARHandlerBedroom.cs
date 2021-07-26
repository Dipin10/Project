using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;
public class SingleARHandlerBedroom: MonoBehaviour
{
    [SerializeField] private ARPlacementInteractable placementInteractable;

    private Items[] items;

    public void Start()
    {

      //  items = Resources.LoadAll<Items>("Bedroom");
       // placementInteractable.placementPrefab = items[LivingroomManager.instance.ItemIndex].ItemModel;
       // Debug.Log(LivingroomManager.instance.ItemIndex);
    }
    public void AfterObjectPlacement()
    {
        placementInteractable.placementPrefab = null;
    }
}