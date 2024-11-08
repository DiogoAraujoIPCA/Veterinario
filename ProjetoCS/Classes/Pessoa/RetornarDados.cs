
/*Ficheiro onde estão agrupados todos os metodos que irão retornar 
dados para o utilziador*/

public partial class Pessoa
{
    #region Metodos Retornar Dados da Pessoa

    public void RetornarNome()
    {
        Validacoes.EspacoEntreOperacoes(1);
        Console.WriteLine("Identificar Nome:");
        if (Nome == null)
        {
            Console.WriteLine("Nome não atribudo");
        }
        else
        {
            Console.WriteLine(Nome);

        }


    }

    public void RetornarMorada()
    {
        Validacoes.EspacoEntreOperacoes(1);
        Console.WriteLine("Identificar Morada:");
        if (Morada == null)
        {
            Console.WriteLine("Morada não Atribuda");
        }
        else
        {
            Console.WriteLine(Morada);

        }



    }

    public void RetornarNumeroTelemovel()
    {
        Validacoes.EspacoEntreOperacoes(1);
        Console.WriteLine("Identificar Numero Telemovel:");

        if (NumeroTelemovel == 0)
        {
            Console.WriteLine("NumeroTelemovel não atribudo");
        }
        else
        {
            Console.WriteLine(NumeroTelemovel);

        }


    }

    public void RetornarTodasInformacoes()
    {
        Validacoes.EspacoEntreOperacoes(1);
          Validacoes.IdentificacaoOperacao("Identificar Informações Pessoa:");
  

        RetornarMorada();
        RetornarNome();
        RetornarNumeroTelemovel();


    }
    #endregion


}

