using System.Security.Cryptography.X509Certificates;

public partial class Consulta{

    protected List<string> condicoesMedicasBD;



    public bool  CriarCondicaoMedica(){
        Auxliar.EspacoEntreOperacoes(1);
        Auxliar.IdentificacaoOperacao("Criar Nova COndição Medica");

        Console.WriteLine("Insira o  Nome Comum :");
        string Nome_Comum=   Console.ReadLine();
        Console.WriteLine("Insira o  Nome especifico:");
        string Nome_Especifico= Console.ReadLine();
        
        bool resultado= AdicionarCondicaoMedica (Nome_Comum+"_"+Nome_Especifico);
        return resultado;
    }
   public bool AdicionarCondicaoMedica(string NovaCondiçãoMedica){
    
    Auxliar.EspacoEntreOperacoes(1);
    Auxliar.IdentificacaoOperacao("Adicionar Nova condição:");
    if (!VerificarExistenciaCondicao(NovaCondiçãoMedica)){
        
         condicoesMedicasBD.Add(NovaCondiçãoMedica);
          Console.WriteLine("Condição "+NovaCondiçãoMedica+" adicionada");
          return true;
    }else{
        Console.WriteLine("Condição "+NovaCondiçãoMedica+"já existente");
          return false;
    }
   

   }

   public void ListarTodasCondicoesMedica(){
    Auxliar.EspacoEntreOperacoes(1);
    Auxliar.IdentificacaoOperacao("Listar Todas Condições Medicas");
    int i=0;
        foreach(Diagnostico Condicao in ListaCondicoes ){
            Console.WriteLine(+ i + ")"+Condicao.RetornarNomeDiagnostico());
            i++;
        }
   }
   public bool VerificarExistenciaCondicao(string _Condicao){

    if (condicoesMedicasBD.Contains(_Condicao)){
        return true;
    }else{
        return false;
    }


    
    
        
   }
}