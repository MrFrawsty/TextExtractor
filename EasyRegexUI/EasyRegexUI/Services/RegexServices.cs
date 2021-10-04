using EasyRegexLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EasyRegexUI.Services
{
    public class RegexServices
    {
public static async Task<List<string>> CallRegexMethod(string filePath, Func<string, MatchCollection> regexMethod)
     {

            var result = await EasyRegex.ReadFromFileAsync(filePath, regexMethod);

            var resultList = result.Cast<Match>().Select(match => match.Value).ToList();

            return resultList;
     }
        

    }
}
