using Autofac;
using AutoMapper.Contrib.Autofac.DependencyInjection;
using FluentValidation;
using MediatR.Extensions.Autofac.DependencyInjection;
using SPENGO.Data.Interfaces;
using SPENGO.Data.Repositories;
using SPENGO.Domain.Helpers.Interfaces;
using SPENGO.Domain.Helpers.Services;
using SPENGO.Domain.Mappers;
using SPENGO.Domain.Models.RequestModels.CommandRequestModels;
using SPENGO.Domain.Models.RequestModels.QueryRequestModels;
using SPENGO.Domain.Validators;
using System;

namespace SPENGO.API.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterMediatR(AppDomain.CurrentDomain.Load("SPENGO.Domain"));

            containerBuilder.RegisterAutoMapper(typeof(MappingProfile).Assembly);

            containerBuilder.RegisterType<AddWalletRequestModelValidator>().As<IValidator<AddWalletRequestModel>>();
            containerBuilder.RegisterType<DeleteWalletRequestModelValidator>().As<IValidator<DeleteWalletRequestModel>>();
            containerBuilder.RegisterType<GetAllWalletRequestModelValidator>().As<IValidator<GetAllWalletRequestModel>>();
            containerBuilder.RegisterType<GetWalletByIdRequestModelValidator>().As<IValidator<GetWalletByIdRequestModel>>();
            containerBuilder.RegisterType<UpdateWalletRequestModelValidator>().As<IValidator<UpdateWalletRequestModel>>();

            containerBuilder.RegisterType<WalletRepository>().As<IWalletRepository>();

            containerBuilder.RegisterType<GenerateIdHelper>().As<IGenerateIdHelper>();
        }
    }
}
