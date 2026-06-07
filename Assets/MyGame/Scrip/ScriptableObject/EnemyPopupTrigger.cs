using UnityEngine;

[RequireComponent(typeof(Collider2D))] 
[RequireComponent(typeof(EnemyController))] 
public class EnemyPopupTrigger : MonoBehaviour
{
    private EnemyController enemyController;

    private void Start()
    {
        enemyController = GetComponent<EnemyController>();

        Collider2D col = GetComponent<Collider2D>();
        if (col != null)
        {
            col.isTrigger = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (PopUpGetInfomation.Instance != null && enemyController != null)
            {
                PopUpGetInfomation.Instance.ShowPopup(enemyController.data);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (PopUpGetInfomation.Instance != null)
            {
                PopUpGetInfomation.Instance.HidePopup();
            }
        }
    }
}