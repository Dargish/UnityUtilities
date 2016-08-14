using UnityEngine;

public class CachedComponent<T> where T : Component
{
    GameObject gameObject_;
    T component;

    public GameObject gameObject
    {
        get { return gameObject_; }
        set { gameObject_ = value; component = null; }
    }

    public CachedComponent(GameObject gameObject)
    {
        gameObject_ = gameObject;
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
