﻿using System;
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
        private readonly ICombosHelper _combosHelper;
        public ConverterHelper(ICombosHelper combosHelper
            ,DataContext dataContext)
        {
            _dataContext = dataContext;
            _combosHelper = combosHelper;
            
        }
       

        public async Task<Property> ToPropertyAsync(PropertyViewModel model, bool isNew)
        {
            return new Property
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

        public PropertyViewModel ToPropertyViewModel(Property property)
        {
            return new PropertyViewModel
            {

                Address=property.Address,                
                Contracts =property. Contracts,
                HasParkingLot = property.HasParkingLot,
                Id =  property.Id,
                IsAvailable = property.IsAvailable,
                Neighborhood = property.Neighborhood,
                Owner = property.Owner,
                Price = property.Price,
                PropertyImages =  property.PropertyImages,
                PropertyType =property.PropertyType,
                Remarks = property.Remarks,
                Rooms = property.Rooms,
                SquareMeters = property.SquareMeters,
                Stratum = property.Stratum,
                OwnerId = property.Owner.Id,               
                PropertyTypeId = property.PropertyType.Id,
                PropertyTypes = _combosHelper.GetComboPropertyTypes()

            };

        }

        public async Task<Contract> ToContractAsync(ContractViewModel model,bool isNew)
        {
            return new Contract
            {
                EndDate = model.EndDate.ToUniversalTime(),
                IsActive = model.IsActive,
                Lessee = await _dataContext.Lessees.FindAsync(model.LesseeId),
                Owner = await _dataContext.Owners.FindAsync(model.OwnerId),
                Price = model.Price,
                Property = await _dataContext.Properties.FindAsync(model.PropertyId),
                Remarks = model.Remarks,
                StartDate = model.StartDate.ToUniversalTime(),
                Id = isNew ?0: model.Id
            };

        }
        public ContractViewModel ToContractViewModel(Contract contract)
        {
            return new ContractViewModel
            {
                EndDate = contract.EndDate.ToLocalTime(),
                Id = contract.Id,
                IsActive = contract.IsActive,
                Lessee=contract.Lessee,
                LesseeId = contract.Lessee.Id,
                OwnerId = contract.Owner.Id,
                Owner =contract.Owner,
                Property=contract.Property,
                Price = contract.Price,
                Remarks = contract.Remarks,
                StartDate = contract.StartDate.ToLocalTime(),                
                Lessees = _combosHelper.GetComboLessees(),
                PropertyId = contract.Property.Id
            };
        }

    }
}
