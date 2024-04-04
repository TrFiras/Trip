using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trip.Data.Interfaces;

namespace Trip.Data.Repositories
{
   public class GenericRepoType<T>
{
    public T Field;
}

}