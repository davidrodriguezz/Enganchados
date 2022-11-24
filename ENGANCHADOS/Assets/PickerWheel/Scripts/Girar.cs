using EasyUI.PickerWheelUI;

using UnityEngine;
using UnityEngine.UI;

public class Girar : MonoBehaviour
{
    [SerializeField] private Button uiSpinButton;

    [SerializeField] private PickerWheel pickerWheel;


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
            });
            pickerWheel.Spin();

        });
    }

}