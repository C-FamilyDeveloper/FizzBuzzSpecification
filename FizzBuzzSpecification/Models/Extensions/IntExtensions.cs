using FizzBuzzSpecification.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzSpecification.Models.Extensions
{
    public static class IntExtensions
    {
        public static string ReplaceWithSpecifications(this int source, SpecificationHandler<int> specificationHandler)
        {
            return specificationHandler.ExecuteAction(source);
        }
    }
}
