using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using uAdventure.Unity;
using uAdventure.Core;
using uAdventure.Analytics;
using uAdventure.Runner;
using EasyUI.PickerWheelUI;

public class CambioEscena : MonoBehaviour
{
    public GameObject pickerWheel;
    private string[] listaEscenas = { "Clase", "ColegioExt2" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pickerWheel.GetComponent<PickerWheel>().cont > 0&&!pickerWheel.GetComponent<PickerWheel>().isSpinning())
        Game.Instance.Execute(new EffectHolder(new Effects { new TriggerSceneEffect(listaEscenas[1], 0, 0) }));
    }
}
