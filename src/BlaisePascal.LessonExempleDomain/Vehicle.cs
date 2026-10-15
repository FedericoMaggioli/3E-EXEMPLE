using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.LessonExempleDomain
{
    public class Vehicle
    {
        private int _odometerKm;
        private double _dailyRate;
        private double _fuelLevelPercentage;
        private string _licensePlate;
        public string LicensePlate
        {
            get { return _licensePlate; }
            private set
            {
                //controllo sulla targa - non nulla, non vuota, lunghezza 7 caratteri deve avere 2 lettere 3 numeri e 2 lettere
                if (string.IsNullOrWhiteSpace(value) || value.Length != 7)
                    throw new ArgumentException($"value not allowed {nameof(LicensePlate)}: {value} ");
                if (!char.IsLetter(value[0]) || !char.IsLetter(value[1]) || !char.IsDigit(value[2]) || !char.IsDigit(value[3]) || !char.IsDigit(value[4]) || !char.IsLetter(value[5]) || !char.IsLetter(value[6]))
                    throw new ArgumentException($"value not allowed {nameof(LicensePlate)}: {value} ");

                _licensePlate = value;

            }
        }
        public int OdometerKm
        {
            get
            { return _odometerKm; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException($"value not allowed {nameof(OdometerKm)}: {value} ");

                _odometerKm = value;
            }
        }
        public double DailyRate { get; private set; }

        public double FuelLevelPercentage
        {
            get
            { return _fuelLevelPercentage; }
            private set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException($"value not allowed {nameof(FuelLevelPercentage)}: {value} ");

                _fuelLevelPercentage = value;
            }
        }


        /// <summary>
        /// metodo costruttore che inizializza la targa del veicolo
        /// </summary>
        /// <param name="licensePlate"></param>
        public Vehicle(string licensePlate)
        {
            //TODO: validazione della targa
            LicensePlate = licensePlate; //chiama al set           
        }

        /// <summary>
        /// metodo costruttore che inizializza la targa del veicolo, il contachilometri, il prezzo giornaliero e il livello di carburante
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="odometerKm"></param>
        /// <param name="dailyRate"></param>
        /// <param name="fuelLevelPercentage"></param>
        public Vehicle(string licensePlate, int odometerKm,
            double dailyRate, double fuelLevelPercentage)
        {
            LicensePlate = licensePlate;
            OdometerKm = odometerKm; //chiamata al set
            DailyRate = dailyRate;
            FuelLevelPercentage = fuelLevelPercentage;
        }

        public void RegisterData(int consumedKm, double consumedFuel)
        {
            //controlli sui parametri (argument)
            if (consumedKm <= 0)
                throw new ArgumentException($"value not allowed {nameof(consumedKm)}: {consumedKm} ");
            if (consumedFuel < 0)
                throw new ArgumentException($"value not allowed {nameof(consumedFuel)}: {consumedFuel} ");

            //aggiorno lo stato dell'oggetto
            OdometerKm += consumedKm; //chiamata al set
            FuelLevelPercentage -= consumedFuel; //chiamate set
        }


    }
}
