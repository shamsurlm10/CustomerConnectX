﻿using AutoMapper;
using CustomerService.Models;
using CustomerService.Models.CustomerDto;
using CustomerService.Models.ServiceDto;

namespace CustomerService.Configurations
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            #region Customer
            CreateMap<Customer, CustomerListDto>();
            CreateMap<Customer, CustomerListWithServiceDto>().ForMember(dest => dest.ServicesForCustomer, o => o.MapFrom((src => src.Services)));
            CreateMap<CustomerAddDto, Customer>();
            CreateMap<CustomerDeleteOrUpdateDto, Customer>();
            #endregion

            #region Service
            CreateMap<Service, ServiceListDto>();
            CreateMap<ServiceAddDto, Service>();
            CreateMap<ServiceDeleteOrUpdateDto, Service>();
            #endregion
        }
    }
}
