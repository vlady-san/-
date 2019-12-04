using System;
using System.Linq;
using Xrm.ReportUtility.Infrastructure;
using Xrm.ReportUtility.Interfaces;
using Xrm.ReportUtility.Models;
using Xrm.ReportUtility.Printers;
using Xrm.ReportUtility.Services;

namespace Xrm.ReportUtility
{
    public static class Program
    {
        // "Files/table.txt" -data -weightSum -costSum -withIndex -withTotalVolume
        public static void Main(string[] args)
        {
            var service = GetReportService(args);

            var report = service.CreateReport();

            PrintReport(report);

            Console.WriteLine("");
            Console.WriteLine("Press enter...");
            Console.ReadLine();
        }

        private static IReportService GetReportService(string[] args)
        {
            var filename = args[0];
            ChainOfReports c = new ChainOfReports();
            return c.CreateReportService(filename, args);

            /* Данный класс очень сильно привязан к TxtReportService, CsvReportService,
              XlsxReportService. При добавлении новых форматов входных данный, число таких зависимостей будет только расти.
              Задача данного кусочка кода, создать ОДИН reportService, а создаются они по реакции на расширение входного файла.
              Я решила сделать цепочку обязанностей, чтобы при запуске, мы прошлись по всем классам, входящим
              в цепочку, и определенный класс, прореагировавщий на свое расширение, вернул нам соответсвующий сервис.
              
             */


            /*if (filename.EndsWith(".txt"))
            {
                return new TxtReportService(args);
            }

            if (filename.EndsWith(".csv"))
            {
                return new CsvReportService(args);
            }

            if (filename.EndsWith(".xlsx"))
            {
                return new XlsxReportService(args);
            }

            throw new NotSupportedException("this extension not supported");*/
        }

       
        private static void PrintReport(Report report)
        {
            /*
             В данном методе мы рисуем таблицу на консоль. У нас есть рисовка стандартной таблицы, а также рисовка дополнительных столбцов, в зависимости от
             параметров, введенных пользователем. Рисовка дополнительных столбцов, как я думаю, это расширение функциональности, поэтому я решила сделать декоратор.
             В качесве объекта я использовала стандартный вывод таблицы,
             а именно StandartPrinter, а в качестве оберток другие принтеры(WithIndexPrinter,WithTotalVolumePrinter,WithTotalWeighPrintert), которые добавляют свою функциональность к стандартному принтеру.
             */
            if (report.Config.WithData && report.Data != null && report.Data.Any())
            {
                /*var headerRow = "Наименование\tОбъём упаковки\tМасса упаковки\tСтоимость\tКоличество";
                var rowTemplate = "{1,12}\t{2,14}\t{3,14}\t{4,9}\t{5,10}";*/
                String headerRow = "";
                String rowTemplate = "";
                IReportPrinter printer = new StandartPrinter();
                if (report.Config.WithIndex)
                {
                    printer = new WithIndexPrinter(printer);
                    /*headerRow = "№\t" + headerRow;
                    rowTemplate = "{0}\t" + rowTemplate;*/
                }
                if (report.Config.WithTotalVolume)
                {
                    printer = new WithTotalVolumePrinter(printer);
                    /*headerRow = headerRow + "\tСуммарный объём";
                    rowTemplate = rowTemplate + "\t{6,15}";*/
                }
                if (report.Config.WithTotalWeight)
                {
                    printer = new WithTotalWeightPrinter(printer);
                    /*headerRow = headerRow + "\tСуммарный вес";
                    rowTemplate = rowTemplate + "\t{7,13}";*/
                }
                printer.Print(headerRow,rowTemplate);

                Console.WriteLine(headerRow);

                for (var i = 0; i < report.Data.Length; i++)
                {
                    var dataRow = report.Data[i];
                    Console.WriteLine(rowTemplate, i + 1, dataRow.Name, dataRow.Volume, dataRow.Weight, dataRow.Cost, dataRow.Count, dataRow.Volume * dataRow.Count, dataRow.Weight * dataRow.Count);
                }

                Console.WriteLine();
            }

            if (report.Rows != null && report.Rows.Any())
            {
                Console.WriteLine("Итого:");
                foreach (var reportRow in report.Rows)
                {
                    Console.WriteLine(string.Format("  {0,-20}\t{1}", reportRow.Name, reportRow.Value));
                }
            }
        }
    }
}