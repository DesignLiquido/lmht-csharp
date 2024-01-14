using System.Xml.Xsl;

namespace DesignLiquido.LmhtCSharp
{
    public class ConversorLmht
    {
        private readonly XslCompiledTransform xslt;

        public ConversorHtml()
        {
            this.xslt = new XslCompiledTransform(true);
            this.xslt.Load("./especificacao/lmht10.xslt");
        }
    }
}