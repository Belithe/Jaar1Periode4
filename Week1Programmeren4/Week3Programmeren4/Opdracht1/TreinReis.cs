using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1
{
    public class TreinReis : ITreinReis
    {
        private List<TreinStation> stations;
        private int huidigStation;
        private List<ITreinDisplay> observers;
        public TreinReis()
        {
            stations = new List<TreinStation>();
            observers = new List<ITreinDisplay>();
            stations.Add(new TreinStation("Den Helder", "b4", new DateTime(1999, 8, 22, 12, 32, 12), new DateTime(2000, 8, 12, 12, 33, 12)));
            stations.Add(new TreinStation("Alkmaar", "b3", new DateTime(2000, 8, 22, 12, 34, 12), new DateTime(2001, 8, 12, 12, 35, 12)));
            stations.Add(new TreinStation("Castricum", "b2", new DateTime(2001, 8, 22, 12, 36, 12), new DateTime(2002, 8, 12, 12, 37, 12)));
            huidigStation = 0;
        }

        public void AddObserver(ITreinDisplay observerToAdd)
        {
            observers.Add(observerToAdd);
        }

        public void RemoveObserver(ITreinDisplay observerToRemove)
        {
            observers.Remove(observerToRemove);
        }

        public void NotifyObservers(TreinStation station)
        {
            foreach (ITreinDisplay observer in observers)
            {
                observer.Update(station);
            }
        }

        public void TurnAround()
        {
            TreinStation station = stations[huidigStation];
            stations.Reverse();
            huidigStation = stations.IndexOf(station);
            
        }

        public void VolgendStation()
        {
            try
            {
                huidigStation++;
                NotifyObservers(stations[huidigStation]);
            } catch
            {
                huidigStation--;

            }
        }
    }
}
