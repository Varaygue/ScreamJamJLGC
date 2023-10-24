using UnityEngine;

public class OpenURLOnClick : MonoBehaviour
{
    public string faURL;
    public string ktURL;
    public string kiURL;
    public string aiURL;
    public string asURL;

    public void FArtLink()
    {
        Application.OpenURL(faURL);
    }
    public void KTLink()
    {
        Application.OpenURL(ktURL);
    }
    public void KILink()
    {
        Application.OpenURL(kiURL);
    }
    public void AILink()
    {
        Application.OpenURL(aiURL);
    }
    public void ASLink()
    {
        Application.OpenURL(asURL);
    }
}
