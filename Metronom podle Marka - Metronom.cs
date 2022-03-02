using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Collections;

namespace ConsoleApp_1
{
    class Metronome
    {
        // readonly - dá se přiřadit jednou a pak se nedá měnit, "constanta" - vytvoří se když se vytvoří třída a zůstane taková
        // const - nedá se nikdy změnit, je v programu
        private readonly int period;

        // Action <=> public delegate void Název()
        private Action Listener;

        private Timer timer;

        public Metronome(int period)
        {
            this.period = period;
        }

        public void SetOnTickListener(Action Listener)
        {
            this.Listener = Listener;
        }
        // public void SetOnTickListener(Action Listener) => this.Listener = Listener;

        // Časovače
        public void Start()
        {
            // Sleep.Thread - problém v metronomu: jede jen jedna větev a nemůže dělat více věcí

            // Delegát, co se má vytvořit a jaká je jeho akce
            // TimerAkce - jeho podmínka, null - nic, zbytečný 
            // timer = new Timer(TimerAkce, null, 0, period);

            // TimerAkce - nahrazen anonymní fcí
            timer = new Timer((x) => {
                if (Listener != null) Listener();
            }, null, 0, period);

        }

        public void Stop()
        {
            if (timer == null) return; //Aby se někdo akci nepokoušel vypnout while není fční
            timer.Dispose();

        }

        // Object x je null
        /*private void TimerAkce(object x)
        {
            if (Listener != null) Listener();

        }*/
    }
}
