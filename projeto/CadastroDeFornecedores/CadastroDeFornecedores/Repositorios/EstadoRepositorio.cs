using System.Collections.Generic;

namespace CadastroDeFornecedores.Repositorios
{
    public class EstadoRepositorio
    {
        private List<string> _estados;

        public EstadoRepositorio()
        {
            _estados = new List<string>()
            {
                "AC","AL","AP",
                "AM","BA","CE",
                "DF","ES","GO",
                "MA","MT","MS",
                "MG","PA","PB",
                "PR","PE","PI",
                "RJ","RN","RS",
                "RO","RR","SC",
                "SP","SE","TO",
            };
        }

        public List<string> GetAllEstados()
        {
            return _estados;
        }

        public string GetByCode(int code)
        {
            return _estados[code - 1];
        }
    }
}