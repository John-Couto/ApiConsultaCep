using ApiConsultaCep;
using Refit;


    try
    {
    var cepClient = RestService.For<ICepApiService>("http://viacep.com.br");
    Console.WriteLine("informe seu cep:");
    string cepInformado = Console.ReadLine().ToString();
    Console.WriteLine("Consultando informações do CEP:" + cepInformado);

    var address = await cepClient.GetAddressAsync(cepInformado);

    Console.WriteLine($"\nLogradouro:{address.Logradouro},\nBairro:{address.Bairro},\nCidade:{address.Localidade}");
    Console.ReadKey();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

