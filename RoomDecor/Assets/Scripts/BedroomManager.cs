using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BedroomManager : MonoBehaviour
{
    [SerializeField] private GameObject itemPanelPrefab;

    [SerializeField] private Transform content;//itemContainer

    private GameObject itemPanel;

    private Items[] items;

    private int index = 0;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void PassItemIndexToSingleAR(int index)
    {
        switch (index)
        {
            case 0:
                SceneManager.LoadScene("PrethDoubleDresser");
                break;
            case 1:
                SceneManager.LoadScene("DecorativeTable");
                break;
            case 2:
                SceneManager.LoadScene("Drawer");
                break;
            case 3:
                SceneManager.LoadScene("GlassDesignTableLamp");
                break;
            case 4:
                SceneManager.LoadScene("Bed");
                break;
            case 5:
                SceneManager.LoadScene("SingleARBedroom");
                break;
            case 6:
                //SceneManager.LoadScene("SingleARBedroom");
                break;
            case 7:

                //SceneManager.LoadScene("SingleARBedroom");
                break;
        }
    }

    private void Start()
    {

        items = Resources.LoadAll<Items>("Bedroom");
        foreach (Items item in items)
        {
            int itemIndex = index;
            itemPanel = Instantiate(itemPanelPrefab);
            itemPanel.transform.SetParent(content);
            itemPanel.GetComponentInChildren<Text>().text = item.ItemName;
            itemPanel.GetComponentInChildren<RawImage>().texture = item.ItemImage;
            itemPanel.GetComponent<Button>().onClick.AddListener(() => PassItemIndexToSingleAR(itemIndex));
            index++;

        }
    }
}
