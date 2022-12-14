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
    //public GameObject pickerWheel;
    //private string[] listaEscenas = { "Clase", "ColegioExt2" };
    //float time = 2.0f;
    //float timer = 0.0f;

    // Update is called once per frame
    void Update()
    {

        //if (pickerWheel.GetComponent<PickerWheel>().cont > 0 && !pickerWheel.GetComponent<PickerWheel>().isSpinning())
        //{
        //    timer += Time.deltaTime;
        //    if (timer>=time)
        //    Game.Instance.Execute(new EffectHolder(new Effects { new TriggerSceneEffect(listaEscenas[1], 0, 0) }));
        //}

    }
    public void CambiaARuleta()
    {
        Game.Instance.Execute(new EffectHolder(new Effects { new TriggerSceneEffect("MinijuegoRuleta", 0, 0) }));
    }
    public void CambiaARuleta2()
    {
        Game.Instance.Execute(new EffectHolder(new Effects { new TriggerSceneEffect("MinijuegoRuleta2", 0, 0) }));
    }
    public void CambiaAJuego()
    {
        Game.Instance.Execute(new EffectHolder(new Effects { new TriggerSceneEffect("KillZomb", 0, 0) }));
    }
    public void CambiaAJuego2()
    {
        Game.Instance.Execute(new EffectHolder(new Effects { new TriggerSceneEffect("KillZomb2", 0, 0) }));
    }
    public void CambiaAMovilJuego()
    {
        Game.Instance.Execute(new EffectHolder(new Effects { new TriggerSceneEffect("MobileMinijuego", 0, 0) }));
    }
    public void CambiaAMovilRuleta()
    {
        Game.Instance.Execute(new EffectHolder(new Effects { new TriggerSceneEffect("MobileRuleta", 0, 0) }));
    }
    public void CambiaAMensajes()
    {
        Game.Instance.Execute(new EffectHolder(new Effects { new TriggerSceneEffect("MobileAbuela", 0, 0) }));
    }
    public void CambiaAHabitacion3()
    {
        Game.Instance.Execute(new EffectHolder(new Effects { new TriggerSceneEffect("Dia1Habitacion3", 0, 0) }));

    }
    public void CambiaAMovilJuego2()
    {
        Game.Instance.Execute(new EffectHolder(new Effects { new TriggerSceneEffect("MobileMiniJuego2", 0, 0) }));
    }
    public void CambiaAHabitacion4()
    {
        Game.Instance.Execute(new EffectHolder(new Effects { new TriggerSceneEffect("Dia1Habitacion4", 0, 0) }));


    }
    public void CambiaaDia2Habitacion3()
    {
        Game.Instance.Execute(new EffectHolder(new Effects { new TriggerSceneEffect("Dia2Habitacion3", 0, 0) }));

    }
    public void CambiaaDia2Habitacion4()
    {
        Game.Instance.Execute(new EffectHolder(new Effects { new TriggerSceneEffect("Dia2Habitacion4", 0, 0) }));

    }

}