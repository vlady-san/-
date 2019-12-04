using Xrm.ReportUtility.Infrastructure.Transformers;
using Xrm.ReportUtility.Interfaces;
using Xrm.ReportUtility.Models;

namespace Xrm.ReportUtility.Infrastructure
{
    public static class DataTransformerCreator
    {
        public static IDataTransformer CreateTransformer(ReportConfig config)
        {
            IDataTransformer service = new DataTransformer(config);

            /*
             Здесь использован декоратор. Мы оборачиваем последовательно переменную сервис, в классы-наследники класса ReportServiceTransformerBase,
             в зависимости от параметров, которые ввел пользватель. А далее вызываем метод TransformData, который реализуют все декораторы, тем самым добавляя
             новую функциональность.
             */

            /*
             Здесь можно применить еще один паттерн-цепочку обязанностей. Мы бы составили цепочку из всех классов, которые созданы ниже и передали бы им config,
             а классы сами бы решали могут ли они в зависимости от заданной конфигурации что то делать дальше, или нужно дальше переходить по цепочке.
             Тогда бы у нас исчезла прямая зависимость данного класса от классов, которые создаются ниже, а также все if.
             */
            if (config.WithData)
            {
                service = new WithDataReportTransformer(service);
            }

            if (config.VolumeSum)
            {
                service = new VolumeSumReportTransformer(service);
            }

            if (config.WeightSum)
            {
                service = new WeightSumReportTransfomer(service);
            }

            if (config.CostSum)
            {
                service = new CostSumReportTransformer(service);
            }

            if (config.CountSum)
            {
                service = new CountSumReportTransformer(service);
            }

            return service;
        }
    }
}