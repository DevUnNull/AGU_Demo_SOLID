using UnityEngine;

public class EnemyController : MonoBehaviour, IUpdate
{
    private void OnEnable()
    {
        UpdateManager.Instance.Subscribe(this);
    }

    private void OnDisable()
    {
        UpdateManager.Instance.Unsubscribe(this);
    }

    public void OnCustomUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }

    //private void Update()
    //{
    //    transform.Translate(Vector3.forward * Time.deltaTime);
    //}
}
