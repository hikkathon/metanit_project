using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metanit_wpf_mvvm.Models
{
    interface IFileService
    {
        List<Phone> Open(string filename);
        void Save(string filename, List<Phone> phonesList);
    }
}
