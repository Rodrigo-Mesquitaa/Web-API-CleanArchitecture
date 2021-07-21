namespace Ginasio.Core.DTOs

{
    public class AdicionarPessoaErpDTO
    {
        public AdicionarPessoaErpDTO(string nome_Completo, string numero_Documento)
        {
            Nome_Completo = nome_Completo;
            Numero_Documento = numero_Documento;
        }
        public string Nome_Completo { get; set; }
        public string Numero_Documento { get; private set; }
    }
}