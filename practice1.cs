using System;



namespace BugInMount

{

    class Program

    {

        enum ProductGroup

        {

            Одяг,

            Взуття,

            Eлектротовари

        }



        enum ProductName

        {

            Футболка = 1,

            Джинси,

            Кросівки,

            Чоботи,

            Смартфон,

            Ноутбук,

            Навушники,

            Смартгодинник,

            Фотокамера

        }



        static void Main(string[] args)

        {

            Console.WriteLine("Ласкаво просимо до програми перерахування товарів!");

            Console.WriteLine();



            Console.WriteLine("Ось доступні товари:");

            Console.WriteLine("{0,-15} {1,-15} {2,-15}", "Номер товару", "Група товару", "Назва товару");



            foreach (ProductName productName in Enum.GetValues(typeof(ProductName)))

            {

                Console.WriteLine("{0,-15} {1,-15} {2,-15}", (int)productName, GetProductGroup(productName), productName);

            }



            Console.WriteLine();



            Console.WriteLine("Будь ласка, введіть номери товарів, які б Ви хотіли придбати, розділяючи їх комами:");

            string input = Console.ReadLine();

            string[] selectedProducts = input.Split(',');



            Console.WriteLine();



            Console.WriteLine("Ви вибрали наступні товари:");

            Console.WriteLine("{0,-15} {1,-15}", "Група товару", "Назва товару");



            foreach (string selectedProduct in selectedProducts)

            {

                int productNumber = int.Parse(selectedProduct.Trim());



                if (Enum.IsDefined(typeof(ProductName), productNumber))

                {

                    ProductName productName = (ProductName)productNumber;

                    Console.WriteLine("{0,-15} {1,-15}", GetProductGroup(productName), productName);

                }

            }



            Console.WriteLine();



            Console.WriteLine("Автор: Демидов");

            Console.WriteLine();

            Console.ReadLine();

        }



        static ProductGroup GetProductGroup(ProductName productName)

        {

            switch (productName)

            {

                case ProductName.Футболка:

                case ProductName.Джинси:

                    return ProductGroup.Одяг;

                case ProductName.Кросівки:

                case ProductName.Чоботи:

                    return ProductGroup.Взуття;

                case ProductName.Смартфон:

                case ProductName.Ноутбук:

                case ProductName.Навушники:

                case ProductName.Смартгодинник:

                case ProductName.Фотокамера:

                    return ProductGroup.Eлектротовари;

                default:

                    throw new ArgumentException("Неіснуючий товар");



            }

        }

    }

}