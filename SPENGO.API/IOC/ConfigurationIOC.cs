using Autofac;
using AutoMapper.Contrib.Autofac.DependencyInjection;
using FluentValidation;
using MediatR.Extensions.Autofac.DependencyInjection;
using SPENGO.Data.Interfaces;
using SPENGO.Data.Repositories;
using SPENGO.Domain.Mappers;
using SPENGO.Domain.Validators;
using System;

namespace SPENGO.API.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterMediatR(AppDomain.CurrentDomain.Load("SPENGO.Doamin"));

            containerBuilder.RegisterAutoMapper(typeof(MappingProfile).Assembly);

            containerBuilder.RegisterType<AddWalletRequestModelValidator>().As<IValidator<AddWalletRequestModelValidator>>();
            containerBuilder.RegisterType<DeleteWalletRequestModelValidator>().As<IValidator<DeleteWalletRequestModelValidator>>();
            containerBuilder.RegisterType<GetAllWalletRequestModelValidator>().As<IValidator<GetAllWalletRequestModelValidator>>();
            containerBuilder.RegisterType<GetWalletByIdRequestModelValidator>().As<IValidator<GetWalletByIdRequestModelValidator>>();
            containerBuilder.RegisterType<UpdateWalletRequestModelValidator>().As<IValidator<UpdateWalletRequestModelValidator>>();

            containerBuilder.RegisterType<WalletRepository>().As<IWalletRepository>();
        }
    }
}
