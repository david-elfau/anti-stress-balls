using UnityEngine;

public abstract class  IUIPanel : MonoBehaviour
{
    public abstract void UpdateContent();
    public abstract void RegisterEvents();
    public abstract void UnregisterEvents();

}
