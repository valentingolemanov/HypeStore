using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace StreetwearStore.Services.Mapping
{
    public interface IHaveCustomMappings
    {
        void CreateMappings(IProfileExpression configuration);
    }
}
