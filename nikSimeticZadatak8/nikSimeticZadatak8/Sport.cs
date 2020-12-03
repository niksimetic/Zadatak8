using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikSimeticZadatak8
{
    class Sport
    {
        private string naziv;
        private bool igraLiSeLoptom;
        private byte brojIgraca;

        public string Naziv { get => naziv; set => naziv = value; }
        public bool IgraLiSeLoptom { get => igraLiSeLoptom; set => igraLiSeLoptom = value; }
        public byte BrojIgraca { get => brojIgraca; set => brojIgraca = value; }

        public Sport(string naziv)
        {
            this.naziv = naziv;
        }
        public Sport(string naziv, bool igraLiSeLoptom)
        {
            this.naziv = naziv;
            this.igraLiSeLoptom = igraLiSeLoptom;
        }
        public Sport(string naziv, bool igraLiSeLoptom, byte brojIgraca)
        {
            this.naziv = naziv;
            this.igraLiSeLoptom = igraLiSeLoptom;
            this.brojIgraca = brojIgraca;
        }
    }
}
