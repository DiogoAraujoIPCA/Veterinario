
//Por Terminar
public partial class Consulta
{
    public void AtualizarDataFinal(DateTime NovaDataFinal)
    {

        DataFinal = NovaDataFinal;
    }

    public void AtualizarDataInicial(DateTime NovaDataInicial)
    {

        DataFinal = NovaDataInicial;
    }

    public void AtualizarCondicaoAnimal(CondicoesMedicas condicaonova)
    {
        if (condicaoanimal == condicaonova)
        {
            Console.WriteLine("Insira uma condição do animal diferente");
        }
        else
        {
            condicaoanimal = condicaonova;
        }

    }

    public void AtualizarCondicoesMedicas()
    {

    }

    public void AtualizarCondicaomedicaAnimal()
    {

    }
    public void AtualizarPessoaResponsavel()
    {

    }
    public void AtualizarAnimalConsulta()
    {

    }
    public void AtualizarVeterinarioResponsavel()
    {

    }
}