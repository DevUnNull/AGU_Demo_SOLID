using UnityEngine;
using TMPro; 
public class PopUpGetInfomation : MonoBehaviour
{
    public static PopUpGetInfomation Instance { get; private set; }

    [Header("UI References")]
    [SerializeField] private GameObject popupPanel; 
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private TextMeshProUGUI damageText;
    [SerializeField] private TextMeshProUGUI descriptionText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        HidePopup();
    }


    public void ShowPopup(EnemyData data)
    {
        if (data == null) return;
        nameText.text = data.enemyName;
        hpText.text = "HP: " + data.baseHealth.ToString();
        damageText.text = "ATK: " + data.baseDamage.ToString();
        descriptionText.text = data.description;


        popupPanel.SetActive(true);
    }

    public void HidePopup()
    {
        popupPanel.SetActive(false);
    }
}