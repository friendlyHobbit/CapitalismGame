using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    GameObject socialPanel;
    GameObject moneyPanel;
    GameObject mailPanel;
    GameObject environmentPanel;

    bool panelBool;

    [SerializeField] GameObject[] panelList;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject panel in panelList)
        {
            panel.SetActive(false);
        }
    }

    // general solution by ProjectMagellan https://www.reddit.com/r/Unity3D/comments/4tgeqf/is_there_an_easy_way_to_disable_all_panels_except/
    void ResetPanels()
    {
        for (int i = 0; i < panelList.Length; i++)
        {
            if (panelList[i].activeSelf) panelList[i].SetActive(false);
        }
    }
    // part of same general solution
    public void OpenPanel(int index)
    {
        ResetPanels();
        panelList[index].SetActive(true);
    }


}
