using MyLeassing.Web.Data.Entities;
using MyLeassing.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MyLeassing.Web.Helpers
{
    public interface IConverterHlelper
    {
        Task<Property> ToPropertyAsync(PropertyViewModel model, bool isNew);
        PropertyViewModel ToPropertyViewModel(Property property);
        Task<Contract> ToContractAsync(ContractViewModel model, bool isNew);

    }
}
