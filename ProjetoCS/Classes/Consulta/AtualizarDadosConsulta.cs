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

    public void AtualizarCondicaoAnimal(string condicaonova)
    {
        if (condicaoanimal == condicaonova && VerificarExistenciaCondicao(condicaonova))
        {
            Console.WriteLine("Insira uma condição do animal diferente");
        }
        else
        {
            AdicionarCondicaoMedica(condicaonova);
            condicaoanimal = condicaonova;
        }
    }

    public void AtualizarPessoaResponsavel(Pessoa _PessoaResponsavel)
    {
        PessoaResponsavel = _PessoaResponsavel;
    }

    public void AtualizarAnimalConsulta() { }

    public void AtualizarVeterinarioResponsavel(Veterinario _VeterinarioResponsavel)
    {
        VeterinarioResponsavel = _VeterinarioResponsavel;
    }


    //Adicionar Diagnostico á Lista

    public void AdicionarDiagnostico(Diagnostico _Diagnostico, Raca Animal)
    {
        Auxliar.EspacoEntreOperacoes(2);
        Auxliar.IdentificacaoOperacao("Adicionar Diagnostico:");
         Auxliar.EspacoEntreOperacoes(1);

        if (verificarDiagnosticoExistente(_Diagnostico))
        {

            ListaCondicoes.Add(_Diagnostico);
            Animal.AdicionarCondicaoMedica(_Diagnostico);

            Console.WriteLine("Diagnostico adicionado com sucesso");
        }
        else
        {
            Console.WriteLine("Diagnostico já existente");
        }
         Auxliar.EspacoEntreOperacoes(1);
    }

    //Remover Diagnostico da Lista
    protected void RemoverDiagnostico(Diagnostico _Diagnostico)
    {
        ListaCondicoes.Remove(_Diagnostico);
    }

    //Verificar Lista de Diagnosticos
    protected bool verificarDiagnosticoExistente(Diagnostico _Diagnostico)
    {
        foreach (Diagnostico diag in ListaCondicoes)
        {
            if (diag.RetornarNomeDiagnostico() == _Diagnostico.RetornarNomeDiagnostico())
            {
                return false;
            }
        }
        return true;
    }

    protected void ListarDiagnostico()
    {
        Auxliar.IdentificacaoOperacao("Listar Diagnosticos Consulta:");
        int i = 0;
        foreach (Diagnostico var in ListaCondicoes)
        {
            Console.WriteLine(i + ")" + var.RetornarNomeDiagnostico());
            i++;
        }
    }
}
