public partial class Consulta{
    

    public void RetornarDescriacaoUtilizador(){

      Auxliar.EspacoEntreOperacoes(1);
      Console.WriteLine("Descricao :\n"+ DescricaoConsulta+ ";");
    }

    public void RetornarDataInicialUtilizador(){

      Auxliar.EspacoEntreOperacoes(1);
      Console.WriteLine("Data Inicial :\n"+ DataInicial+ ";");
    }

     public void RetornarDataFinalUtilizador(){
      Auxliar.EspacoEntreOperacoes(1);
      Console.WriteLine("Data Final :\n"+ DataFinal+ ";");
    }

    public void RetornarPessoaResponsavelUtilizador(){
          PessoaResponsavel.RetornarNome();
    }

    public void RetornarAnimalUtilizador(){

        AnimalConsulta.RetornarNomeAnimal();
    }
    public void RetornarVeterinarioUtilizador(){
        VeterinarioResponsavel.RetornarTodosDados(false);
    }

     
    
     public void RetornarTodasInformacoesConsultaUtilizador(){


       
        Auxliar.IdentificacaoOperacao("Todas Informações Consulta");
         Auxliar.EspacoEntreOperacoes(2);
        RetornarDescriacaoUtilizador();
        RetornarDataInicialUtilizador();
        RetornarDataFinalUtilizador();
        RetornarPessoaResponsavelUtilizador();
        RetornarAnimalUtilizador();
        RetornarVeterinarioUtilizador();
        retornarCondiçoesanimalconsulta();
         Auxliar.EspacoEntreOperacoes(2);
    }

    public void retornarCondiçoesanimalconsulta(){
        Auxliar.EspacoEntreOperacoes(2);

      Console.WriteLine("Lista condições ");
      Auxliar.EspacoEntreOperacoes(2);
      foreach (Diagnostico Di in ListaCondicoes){
       Di.RetornarNomeDiagnosticoUtilizador();
      }
    }

    #region Metodos Retornar Dados 

     public string RetornarDescricao(){

      return DescricaoConsulta;
    }
      public DateTime RetornarDataInicial(){

      return DataInicial;
    }

     public DateTime  RetornarDataFinal(){
        
        return DataFinal;
    }

    public Pessoa RetornarPessoaResponsavel(){
        return PessoaResponsavel;
    }

    public Animal RetornarAnimal(){
        return AnimalConsulta;
    }
    public Veterinario RetornarVeterinario(){
       return VeterinarioResponsavel; 
    }

      public string  RetornarCondicaoAnimal(){
        return condicaoanimal;
    }
    #endregion
  
}