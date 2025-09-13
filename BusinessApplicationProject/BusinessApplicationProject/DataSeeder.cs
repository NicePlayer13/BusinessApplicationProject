using BusinessApplicationProject.Model;

namespace BusinessApplicationProject
{
    /// <summary>
    /// Class to seed the database with some initial data.
    /// </summary>
    public static class DataSeeder
    {
        public static void SeedDatabase(AppDbContext context)
        {
            if (context.Customers.Any()) return;

            // Addresses
            var addr1 = new Address
            {
                Country = "United States",
                City = "New York City",
                ZipCode = "NY 10016",
                StreetAddress = "277 5th Ave"
            };

            var addr2 = new Address
            {
                Country = "United States",
                City = "Santa Monica",
                ZipCode = "CA 90403",
                StreetAddress = "2525 Wilshire Blvd"
            };

            context.Addresses.AddRange(addr1, addr2);
            context.SaveChanges();

            // Customers
            var cust1 = new Customer()
            {
                CustomerNumber = "CU00001",
                CustomerAddressId = addr1.Id,
                CustomerAddress = addr1,
                FirstName = "John",
                LastName = "Smith",
                Email = "js@gmail.com"
            };

            var cust2 = new Customer()
            {
                CustomerNumber = "CU00002",
                CustomerAddressId = addr2.Id,
                CustomerAddress = addr2,
                FirstName = "John",
                LastName = "Wayne",
                Email = "jw@gmail.com"
            };

            context.Customers.AddRange(cust1, cust2);
            context.SaveChanges();

            // ArticleGroups
            var artGrp1 = new ArticleGroup { Name = "Consumer Electronics" };
            context.ArticleGroups.Add(artGrp1);
            context.SaveChanges();

            var artGrp2 = new ArticleGroup { Name = "Personal Computing", ParentId = artGrp1.Id };
            var artGrp3 = new ArticleGroup { Name = "Software" };
            context.ArticleGroups.AddRange(artGrp2, artGrp3);
            context.SaveChanges();

            var artGrp4 = new ArticleGroup { Name = "Subscription Based", ParentId = artGrp3.Id };
            context.ArticleGroups.Add(artGrp4);
            context.SaveChanges();

            var artGrp5 = new ArticleGroup { Name = "Productivity", ParentId = artGrp4.Id };
            context.ArticleGroups.Add(artGrp5);
            context.SaveChanges();

            // Articles
            var art1 = new Article()
            {
                ArticleNumber = "A-00001",
                Name = "MacBook Air 13",
                Price = 2100,
                GroupId = artGrp2.Id
            };

            var art2 = new Article()
            {
                ArticleNumber = "A-00002",
                Name = "Chat GPT Pro 1 Mo",
                Price = 20,
                GroupId = artGrp5.Id
            };

            context.Articles.AddRange(art1, art2);
            context.SaveChanges();

            // Orders
            var ord1 = new Order
            {
                OrderNumber = "O-00001",
                Date = DateTime.Now,
                CustomerId = cust1.Id,
                CustomerDetails = cust1,
                Positions = new List<Position>()
            };

            var ord2 = new Order
            {
                OrderNumber = "O-00002",
                Date = DateTime.Now.AddDays(5),
                CustomerId = cust2.Id,
                CustomerDetails = cust2,
                Positions = new List<Position>()
            };

            context.Orders.AddRange(ord1, ord2);
            context.SaveChanges();


            // Positions
            var positions = new List<Position>
{
    new Position
    {
        PositionNumber = 0,
        ArticleId = art1.Id,
        ArticleDetails = art1,
        Quantity = 1,
        OrderId = ord1.Id,
        OrderDetails = ord1
    },
    new Position
    {
        PositionNumber = 1,
        ArticleId = art2.Id,
        ArticleDetails = art2,
        Quantity = 1,
        OrderId = ord1.Id,
        OrderDetails = ord1
    },
    new Position
    {
        PositionNumber = 0,
        ArticleId = art2.Id,
        ArticleDetails = art2,
        Quantity = 12,
        OrderId = ord2.Id,
        OrderDetails = ord2
    }
};

            context.Positions.AddRange(positions);
            context.SaveChanges();


            // Invoices
            var inv1 = new Invoice
            {
                InvoiceNumber = "I-00001",
                BillingAddressId = addr1.Id,
                BillingAddress = addr1,
                DueDate = ord1.Date.AddDays(30),
                PaymentMethod = PaymentInformationConstants.PaymentMethods.ApplePay,
                PaymentStatus = PaymentInformationConstants.PaymentStatuses.Paid,
                OrderId = ord1.Id,
                OrderInformations = ord1
            };

            var inv2 = new Invoice
            {
                InvoiceNumber = "I-00002",
                BillingAddressId = addr2.Id,
                BillingAddress = addr2,
                DueDate = ord2.Date.AddDays(30),
                PaymentMethod = PaymentInformationConstants.PaymentMethods.CreditCard,
                PaymentStatus = PaymentInformationConstants.PaymentStatuses.Pending,
                OrderId = ord2.Id,
                OrderInformations = ord2
            };

            context.Invoices.AddRange(inv1, inv2);
            context.SaveChanges();

        }
    }
}