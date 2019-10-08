using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyLeassing.Web.Data;
using MyLeassing.Web.Data.Entities;
using MyLeassing.Web.Models;

namespace MyLeassing.Web.Helpers
{
    public class ConverterHelper : IConverterHlelper
    {
       
        private readonly DataContext _dataContext;
        public ConverterHelper(ICombosHelper combosHelper,DataContext dataContext)
        {
            
            _dataContext = dataContext;
        }
        public async Task<Property> ToPropertyAsync(PropertyViewModel model, bool isNew)
        {
            return new PropertyViewModel
            {
                Address = model.Address,
                Contracts=isNew ? new List<Contract>(): model.Contracts,
                HasParkingLot = model.HasParkingLot,
                Id = isNew ? 0 :model.Id,
                IsAvailable = model.IsAvailable,
                Neighborhood = model.Neighborhood,
                Owner = await _dataContext.Owners.FindAsync(model.OwnerId),              
                Price = model.Price,
                PropertyImages = isNew ? new List<PropertyImage>() : model.PropertyImages,
                PropertyType = await _dataContext.PropertyTypes.FindAsync(model.PropertyTypeId),
                Remarks = model.Remarks,
                Rooms = model.Rooms,
                SquareMeters = model.SquareMeters,
                Stratum = model.Stratum,
                
               /* OwnerId = model.Owner.Id,               
                PropertyTypeId = model.PropertyType.Id,
                PropertyTypes = _combosHelper.GetComboPropertyTypes(),*/

            };

        }
    }
}
