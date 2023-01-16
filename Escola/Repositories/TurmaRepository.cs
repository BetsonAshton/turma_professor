using Escola.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Escola.Repositories
{
    public class TurmaRepository
    {

        public void ExportarJson(Turma turma) 
        {
           
            var json = JsonConvert.SerializeObject(turma, Formatting.Indented);

            using(var streamWriter = new StreamWriter($"C:\\temp\\turma_{turma.Id}.json"))
            {
                streamWriter.Write(json);
            }
        
        
        }

        public void ExportarXml(Turma turma)
        {
            var xml = new XmlSerializer(typeof(Turma));

            using (var streamWriter = new StreamWriter($"C:\\temp\\turma_{turma.Id}.xml"))
            {
                xml.Serialize(streamWriter, turma);

            }

        }


    }
}
