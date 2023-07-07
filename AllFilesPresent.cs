using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AllFilesPresent
{
   public class CAllFilesPresent
   {
      public static bool AllFilesPresent(string[] args, ref string strError)
      {
         KeyValuePair<string, bool> kvp_s2blnResult =
         (
            from s in args
            let blnMissing = !File.Exists(s)
            where blnMissing
            select new KeyValuePair<string, bool>(s, blnMissing)
         ).FirstOrDefault();

         strError = kvp_s2blnResult.Key;
         return !kvp_s2blnResult.Value;
      }
   }
}
