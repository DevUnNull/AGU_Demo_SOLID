using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class UpdateManager : Singleton<UpdateManager>
{
    private List<IUpdate> subscribers = new();

    public void Subscribe(IUpdate obj)
    {
        if (obj != null && !subscribers.Contains(obj))
        {
            subscribers.Add(obj);
        }
    }

    public void Unsubscribe(IUpdate obj)
    {
        if (obj != null && subscribers.Contains(obj))
        {
            subscribers.Remove(obj);
        }
    }

    private void Update()
    {
        for (int i = subscribers.Count - 1; i >= 0; i--)
        {
            if (subscribers[i] != null)
            {
                subscribers[i].OnCustomUpdate();
            }
            else
            {
                subscribers.RemoveAt(i);
            }
        }
    }
}




