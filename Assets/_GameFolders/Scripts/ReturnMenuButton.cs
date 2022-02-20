using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnMenuButton : MonoBehaviour
{
    /// <summary>
    /// Unity event'e atanmis method
    /// </summary>
    public void OnButtonClicked()
    {
        //TODO return menu
        GameManager.Instance.LoadMenu();
    }
}
