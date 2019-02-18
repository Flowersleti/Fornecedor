
namespace CadastroDeFornecedores.Servicos
{
    public class ControleDeInjecao
    {
        public static ServicoEmpresa ServicoEmpresa;
        public static ServicoFornecedor ServicoFornecedor;
        public static ServicoTelefone ServicoTelefone;

        static ControleDeInjecao()
        {
            var empresaRepositorio = new Repositorios.EmpresaRepositorio();
            var estadosRepositorio = new Repositorios.EstadoRepositorio();
            var telefoneRepositorio = new Repositorios.TelefoneRepositorio();
            var fornecedorRepositorio = new Repositorios.FornecedorRepositorio();

            ServicoEmpresa = new ServicoEmpresa(empresaRepositorio, estadosRepositorio);
            ServicoFornecedor = new ServicoFornecedor(fornecedorRepositorio, empresaRepositorio);
            ServicoTelefone = new ServicoTelefone(telefoneRepositorio, fornecedorRepositorio);
        }
    }
}