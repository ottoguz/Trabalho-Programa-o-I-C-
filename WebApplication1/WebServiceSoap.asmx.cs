using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebServiceSoap
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceSoap : System.Web.Services.WebService
    {

        [WebMethod]
        //Webmethod que retorna o nome do aluno e o número do RU(3602435)
        public string NomeRU()
        {
            return "NOME: Gustavo Ottoboni RU: 3602435";
        }

        
        [WebMethod]
        //Webmethod que verifica se as condições de cálculo para os lados de um triângulo retângulo
        //utilizando os três últimos dígitos do RU: 3602435 são verdadeiras e 
        //Retorna uma mensagem de sucesso
        public string CalcPitagoras(double a, double b, double c)
        {
            double hipotenusa = Math.Pow(c, 2);
            double cateto1 = Math.Pow(a, 2);
            double cateto2 = Math.Pow(b, 2);
            if(hipotenusa == cateto1 + cateto2)
            {
                return $"Os valores: Hipotenusa = {c}, Cateto 1 = {a} e Cateto 2 = {b} formam um triângulo retângulo!";
            } else
            {
                return "Os valores dados não formam um triângulo retângulo!";
            }
        }
    }
}
