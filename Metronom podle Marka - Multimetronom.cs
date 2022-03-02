using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Collections;

namespace ConsoleApp_1
{
    class Multimetronome
    {
        // readonly - dá se přiřadit jednou a pak se nedá měnit, "constanta" - vytvoří se když se vytvoří třída a zůstane taková
        // const - nedá se nikdy změnit, je v programu
        private readonly int period;

        private List<Action> Listeners = new List<Action>(); // Musí se přidat new

        private Timer timer;

        public Multimetronome(int period)
        {
            this.period = period;
        }

        // Přidání posluchačů
        public void AddOnTickListener(Action Listener)
        {
            Listeners.Add(Listener);
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
                foreach (Action a in Listeners) a();
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
