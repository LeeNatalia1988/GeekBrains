using Microsoft.CodeAnalysis;
using Seminar6.Notes.Core.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6.Notes.Core.Application.Interfaces
{
    public interface IEditor<T, TId>
    {

        Optional<T> GetById(TId id);
        Collection<T> GetAll();

    }
}
