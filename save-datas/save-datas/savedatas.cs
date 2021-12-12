using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace save_datas
{
    [Serializable]
    public class Savedatas
    {
        public string textboxInhalt { get; set; } 
        public bool computer { get; set; }  
        public bool car { get; set; }
        public bool football { get; set; }  
        public bool music { get; set; }


        public void save(string path)
        {

            FileStream fs = new FileStream(path, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, this);

            fs.Dispose();

        }
        public Savedatas load(string path)
        {
            Savedatas SD = new Savedatas(); 

            FileStream fs = new FileStream(path,FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            SD = (Savedatas)bf.Deserialize(fs);

            return SD;
        }

    }
}
