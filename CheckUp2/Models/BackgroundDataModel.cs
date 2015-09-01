using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckUp2.Models {
    class BackgroundDataModel {

        public string Process { get; set; }
        public float CPU { get; set; }
        public int Memory { get; set; }
        public int DiskIO { get; set; }
        public int Network { get; set; }

        public BackgroundDataModel(string Process, float CPU, int Memory, int DiskIO, int Network) {
            this.Process = Process;
            this.CPU = CPU;
            this.Memory = Memory;
            this.DiskIO = DiskIO;
            this.Network = Network;
        }
    }
}
