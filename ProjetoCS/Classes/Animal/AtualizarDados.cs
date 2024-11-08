public partial class Animal{
    
        #region Procedimentos para atualizar Valores
        public void AtualizarResponsavel(Pessoa _Responsavel)
        {     
            Validacoes.IdentificacaoOperacao("Atualizar Responsavel Animal:");
            Responsavel = _Responsavel;
        }

          public void AtualizaNomeRaca(Raça _Raca)
        {     
             Validacoes.IdentificacaoOperacao("Atualizar Nome Raça animal:");
            NomeRaca = _Raca;
        }

        public void AtualizarNumeroChip(int _NumeroChip)
        {
            Validacoes.IdentificacaoOperacao("Atualizar Numero Chip:");
            if( NumeroChip >0 ){
                NumeroChip=_NumeroChip;
            }
            else{
                Console.WriteLine("Não foi possivel atualizar nuemro do chip.");
            }
           
        }
        public void AtualizarNomeAnimal(string _NomeAnimal){

            Validacoes.IdentificacaoOperacao("Atualizar Nome Animal:");
            if(Validacoes.VerificarCampo(NomeAnimal)){
                NomeAnimal=_NomeAnimal;
            }
            else{
                Console.WriteLine("Não foi possivel atualizar nome do animal.");
            }
        }
        
    


        #endregion

}