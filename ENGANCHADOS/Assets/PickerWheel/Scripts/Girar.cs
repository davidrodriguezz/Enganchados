using EasyUI.PickerWheelUI;

using UnityEngine;
using UnityEngine.UI;

public class Girar : MonoBehaviour
{
    [SerializeField] private Button uiSpinButton;

    [SerializeField] private PickerWheel pickerWheel;

    public GameObject image;


    private void Start()
    {
        uiSpinButton.onClick.AddListener(() =>
        {
            uiSpinButton.interactable = false;

            pickerWheel.OnSpinStart(() => Debug.Log("Spin started..."));

            pickerWheel.OnSpinEnd(wheelPiece =>
            {
                Debug.Log("Spin end...");
                uiSpinButton.interactable = true;
                image.GetComponent<Image>().sprite = wheelPiece.Icon;
                image.SetActive(true);
            });
            pickerWheel.Spin();

        });
    }

}