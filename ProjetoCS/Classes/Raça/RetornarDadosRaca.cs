public partial class Raça
{

    #region Metodos para retornar Dados
    public string RetornarNomeRaca()
    {
        if (Nome != null)
        {
            return Nome;
        }
        else
        {
            return "Sem Raça Definida";
        }

    }

    public string RetornarInformacoesRaca()
    {
        if (Informacoes != null)
        {
            return Informacoes;
        }
        else
        {
            return "Sem Informações da raça definidas";
        }
    }
    #endregion

    #region Procedimentos para retornar Dados
    public void RetornarNomeRacaUtilizador()
    {

        if (Nome != null)
        {

            Console.WriteLine(Nome);
        }
        else
        {
            Console.WriteLine("Sem Raça Defifnida");
        }

    }

    public void RetornarInformacoesRacaUtilizador()
    {


        if (Informacoes != null)
        {
            Console.WriteLine("Retornar Informações da Informacoes do animal:");
            Console.WriteLine(Informacoes);
        }
        else
        {
            Console.WriteLine("Sem informações");
        }

    }


    #endregion
}