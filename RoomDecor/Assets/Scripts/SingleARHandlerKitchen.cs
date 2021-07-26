using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;
public class SingleARHandlerKitchen : MonoBehaviour
{
    [SerializeField] private ARPlacementInteractable placementInteractable;

    private Items[] items;

    public void Start()
    {

        //items = Resources.LoadAll<Items>("Kitchen");
      //  placementInteractable.placementPrefab = items[KitchenManager.instance.ItemIndex].ItemModel;
      //  Debug.Log(LivingroomManager.instance.ItemIndex);
    }
    public void AfterObjectPlacement()
    {
        placementInteractable.placementPrefab = null;
    }
}
