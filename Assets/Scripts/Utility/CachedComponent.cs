using UnityEngine;

public class CachedComponent<T> where T : Component
{
    GameObject gameObject;
    T component;

    public CachedComponent(GameObject gameObject)
    {
        this.gameObject = gameObject;
    }

    public T get()
    {
        if (component == null)
        {
            if (gameObject != null)
            {
                component = gameObject.GetComponent<T>();
            }
        }
        return component;
    }
}
