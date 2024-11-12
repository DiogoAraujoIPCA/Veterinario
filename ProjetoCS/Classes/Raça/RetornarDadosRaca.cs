public partial class Raca
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
            return "Sem Raca Definida";
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
            return "Sem Informações da Raca definidas";
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
            Console.WriteLine("Sem Raca Defifnida");
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