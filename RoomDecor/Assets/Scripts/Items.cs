using UnityEngine;
[CreateAssetMenu(fileName = "Items", menuName = "Item")]
public class Items : ScriptableObject
{
    public string ItemName;

    public string ItemDescription;

    public Texture ItemImage;

    public GameObject ItemModel;
}
