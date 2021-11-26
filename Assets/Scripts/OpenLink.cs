using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public void OpenChannel()
    {
        Application.OpenURL("https://www.bing.com/images/search?q=create+an+image&form=HDRSC3&first=1&tsc=ImageBasicHover");
    }
}
