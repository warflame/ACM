using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Mappers
{
   public abstract class MapperBase<Tfirst,Tsecond>
    {

       public Tsecond map(Tsecond tsec, Tfirst tfirst)
       {

           var returnObj = typeof(Tfirst);
           var sourceProps = typeof(Tfirst).GetProperties().Where(x => x.CanRead).ToList();
           var destProps = typeof(Tsecond).GetProperties()
                    .Where(x => x.CanWrite)
                    .ToList();

           foreach (var sourceProp in sourceProps)
           {
               if (destProps.Any(x => x.Name == sourceProp.Name))
               {
                   var p = destProps.First(x => x.Name == sourceProp.Name);
                   p.SetValue(tsec, sourceProp.GetValue(tfirst, null), null);
               }
           }

           return tsec;
       }
   }
}
