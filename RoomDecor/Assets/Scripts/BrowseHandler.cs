using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BrowseHandler : MonoBehaviour
{
    [SerializeField] private GameObject content;//Container

    [SerializeField] private GameObject singleMultipleModelPanel;//single and multiple models

    private int index = 0;

    private void Start()
    {
        //content Container
        foreach (Transform transform in content.transform)
        {
            int roomIndex = index;
            transform.GetComponent<Button>().onClick.AddListener(() => DisplaySingleMultipleModelPanel(roomIndex));
            index++;
        }  
    }

    public void DisplaySingleMultipleModelPanel(int roomNumber)
    {
        /*
         * roomNumber = 0,Livingroom; if case of 0,1,2 show the singleMultipleARViewPanel
         *  roomNumber = 1,Bedroom;
         *   roomNumber = 2,Kitchen; 
         *   roomNumber = 3,Gallery; if case of gallery,change the scene to gallery
         */
        switch (roomNumber)
        {
            case 0://living room
                singleMultipleModelPanel.SetActive(true);
                OnClickedSingleMultipleModelButton("Livingroom","MultipleARLivingroom");
                break;
            case 1://bedrooom
                singleMultipleModelPanel.SetActive(true);
                OnClickedSingleMultipleModelButton("Bedroom", "MultipleARBedroom");
                break;
            case 2://kitchen
                singleMultipleModelPanel.SetActive(true);
                OnClickedSingleMultipleModelButton("Kitchen", "MultipleARKitchen");
                break;
            case 3://gallery 
                SceneManager.LoadScene("Gallery");
                break;
        }
    }

    public void OnClickedSingleMultipleModelButton(string roomScene,string roomMultipleARScene)
    {
        singleMultipleModelPanel.transform.GetChild(0).GetComponent<Button>().onClick.AddListener(() => { SceneManager.LoadScene(roomScene); } );
        singleMultipleModelPanel.transform.GetChild(1).GetComponent<Button>().onClick.AddListener(() => { SceneManager.LoadScene(roomMultipleARScene); });
        singleMultipleModelPanel.transform.GetChild(2).GetComponent<Button>().onClick.AddListener(() => { singleMultipleModelPanel.SetActive(false); });
    }
}
