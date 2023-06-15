namespace WebApplication1.Models
{
    public class PessoaModel
    {
        private int v;
        private object value;

        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string celular { get; set; }



         public PessoaModel(int id, string nome, string email, string celular)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.celular = celular;
        }

    }
}
