using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject UI;
    [SerializeField] GameObject grid;
    [SerializeField] GameObject gameSetup;

    bool hasClickedPlay = false;

    void Update()
    {
        ClickOnPlay();

    }

    private void ClickOnPlay()
    {
        grid.SetActive(hasClickedPlay);
        gameSetup.SetActive(hasClickedPlay);
        UI.SetActive(!hasClickedPlay);

    }

    public void OnPlayClick()
    {
        hasClickedPlay = true;
    }
}
