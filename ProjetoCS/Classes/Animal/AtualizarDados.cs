public partial class Animal{
    
        #region Procedimentos para atualizar Valores
        public void AtualizarResponsavel(Pessoa _Responsavel)
        {     
            Auxliar.IdentificacaoOperacao("Atualizar Responsavel Animal:");
            Responsavel = _Responsavel;
        }

          public void AtualizaNomeRaca(Raca _Raca)
        {     
             Auxliar.IdentificacaoOperacao("Atualizar Nome Raca animal:");
            NomeRaca = _Raca;
        }

        public bool AtualizarNumeroChip(int _NumeroChip)
        {
            Auxliar.IdentificacaoOperacao("Atualizar Numero Chip:");
            if( NumeroChip >0 ){
                NumeroChip=_NumeroChip;
                return true;
            }
            else{
                Console.WriteLine("Não foi possivel atualizar nuemro do chip.");
                return false;
            }
           
        }
        public bool AtualizarNomeAnimal(string _NomeAnimal){

            Auxliar.IdentificacaoOperacao("Atualizar Nome Animal:");
            if(Validacoes.VerificarCampo(NomeAnimal)){
                NomeAnimal=_NomeAnimal;
                return true;
            }
            else{
                Console.WriteLine("Não foi possivel atualizar nome do animal.");
                return false;
            }
        }
        
        #endregion

}