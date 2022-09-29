using static ServicoDePaises.CountryInfoServiceSoapTypeClient;

namespace ConsumindoSOAP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var request = new ServicoDePaises.CountryInfoServiceSoapTypeClient(EndpointConfiguration.CountryInfoServiceSoap12))
            {
                var paises = request.ListOfCountryNamesByCode();

                foreach(var pais in paises)
                {
                    var capitalDoPais = request.CapitalCity(pais.sISOCode);

                    var DDI = request.CountryIntPhoneCode(pais.sISOCode);

                    Console.WriteLine($"Pais: {pais.sName} - Capital do Pais: {capitalDoPais} - DDI: +{DDI}");
                }

                Console.ReadLine();

            }
        }

    }
}


