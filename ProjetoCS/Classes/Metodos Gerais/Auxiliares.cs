public class Responsavel {

    public void CriarResponsavel(Pessoa pessoa, Animal animal){
        pessoa.AdicionarAnimal(animal);
        animal.AtualizarResponsavel(pessoa);
    }
}
public class AdiconarConsulta {

    public void AdicionarConsulta(Consulta Consulta1, Organizacao organizacao){
        organizacao.adicionarConsulta(Consulta1);
    }
}

public class Auxliar{
        public  static void  IdentificacaoOperacao(string NomeOperacao  ){

        
          Console.WriteLine("------------------------------------------------------------");
          Console.WriteLine(NomeOperacao);
          Console.WriteLine("------------------------------------------------------------");
          
    }

    public static void EspacoEntreOperacoes(int NumerosLinhas){
        for (int i = 0 ; i<NumerosLinhas;i++){
            Console.WriteLine("");
        }
    }
    
}



