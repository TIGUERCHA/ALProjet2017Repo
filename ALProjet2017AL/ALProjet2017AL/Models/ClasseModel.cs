using System.Collections.Generic;

namespace ALProjet2017AL.Models
{
    public class ClasseModel
    {
        public string promotion { get; set; }
        public List<EtudiantModel> eleves { get; set; }
        public EcoleModel ecole { get; set; }
        public ClasseModel(string promotion)
        {
            this.promotion = promotion;
        }
    }
}