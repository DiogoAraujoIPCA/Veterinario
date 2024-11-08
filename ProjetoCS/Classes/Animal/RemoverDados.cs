public partial class Animal{
      #region Procedimentos para Remover Atributos
        public void RemoverResposavel()
        {
            Validacoes.IdentificacaoOperacao("Remover Responsavel de "+NomeAnimal+"");
            if (Responsavel != null)
            {
                Console.WriteLine("Responsável removido com sucesso.");
                Responsavel = null;
            }
            else
            {
                Console.WriteLine("Nenhum responsável para remover.");

            }

        }

        public void RemoverRaca()
        {
            Validacoes.IdentificacaoOperacao("Remover Raça de "+NomeAnimal+"");
            if (NomeRaca != null)
            {
                Console.WriteLine("Raça removido com sucesso.");
                NomeRaca = null;
            }
            else
            {
                Console.WriteLine("Nenhum Raça atribuida para remover.");

            }
        }
        #endregion

}