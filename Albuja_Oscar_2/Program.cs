using System;
using System.Collections.Generic;

namespace Albuja_Oscar_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            

            //Console.WriteLine("Hello World!");
        }
        // Se Utilizaría el patrón Singleton para crear una clase de "Gestión de Transporte"
        // que se encargaría de gestionar todas las operaciones relacionadas con el transporte en la aplicación.
        // Esta clase tendría un constructor privado para asegurar que solo exista una instancia de la clase en toda la aplicación.

        public class TransportManager
        {
            private static TransportManager _instance;
            private TransportManager() { }
            public static TransportManager Instance
            {
                get
                {
                    if (_instance == null)
                    {
                        _instance = new TransportManager();
                    }
                    return _instance;
                }
            }
            public void GetTransportInfo(string route)
            {
                // code to get transport information
            }
        }

        // Factory Method: Se utilizaria el patrón Factory Method para crear diferentes tipos de transporte
        // (autobuses, trenes, taxis, etc.) de acuerdo a las necesidades del usuario.
        // Tambien se Crearía una interfaz "ITransport" y diferentes clases que implementen esta interfaz,
        // cada una para un tipo específico de transporte.
        interface ITransport
        {
            string GetTransportType();
            void DisplayInfo();
        }

        class Bus : ITransport
        {
            public string GetTransportType()
            {
                return "Bus";
            }
            public void DisplayInfo()
            {
                // code to display bus information
            }
        }
        class Train : ITransport
        {
            public string GetTransportType()
            {
                return "Train";
            }
            public void DisplayInfo()
            {
                // code to display train information
            }
        }

        class TransportFactory
        {
            public static ITransport GetTransport(string transportType)
            {
                switch (transportType)
                {
                    case "Bus":
                        return new Bus();
                    case "Train":
                        return new Train();
                    default:
                        throw new ApplicationException(string.Format("Invalid transport type: {0}", transportType));
                }
            }
        }







    }
}
