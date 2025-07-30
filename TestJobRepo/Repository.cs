using TestJobRepo.Models;

namespace TestJobRepo;

public class Repository
{
    private int _lengthOffers;
    private int _lengthSuppliers;

    public Repository()
    {
        Suppliers = new List<Supplier>()
        {
            new Supplier()
            {
                Id = 1,
                CreatedAt = DateTime.UtcNow,
                Name = "Test1"
            },
            new Supplier()
            {
                Id = 2,
                CreatedAt = DateTime.UtcNow,
                Name = "Test2"
            },
            new Supplier()
            {
                Id = 3,
                CreatedAt = DateTime.UtcNow,
                Name = "Test3"
            },
            new Supplier()
            {
                Id = 4,
                CreatedAt = DateTime.UtcNow,
                Name = "Test4"
            },
            new Supplier()
            {
                Id = 5,
                CreatedAt = DateTime.UtcNow,
                Name = "Test5"
            }
        };

        Offers = new List<Offer>()
        {
            new Offer()
            {
                Id = 1,
                Stamp = "Stamp1",
                Model = "Model1",
                RegistrationDate = DateTime.UtcNow,
                Supplier = Suppliers[0],
                SupplierId = 1
            },
            new Offer()
            {
                Id = 2,
                Stamp = "Stamp1",
                Model = "Model1",
                RegistrationDate = DateTime.UtcNow,
                Supplier = Suppliers[0],
                SupplierId = 1
            },
            new Offer()
            {
                Id = 3,
                Stamp = "Stamp2",
                Model = "Model2",
                RegistrationDate = DateTime.UtcNow,
                Supplier = Suppliers[1],
                SupplierId = 2
            },
            new Offer()
            {
                Id = 4,
                Stamp = "Stamp1",
                Model = "Model1",
                RegistrationDate = DateTime.UtcNow,
                Supplier = Suppliers[0],
                SupplierId = 1
            },
            new Offer()
            {
                Id = 5,
                Stamp = "Stamp2",
                Model = "Model2",
                RegistrationDate = DateTime.UtcNow,
                Supplier = Suppliers[2],
                SupplierId = 3
            },
            new Offer()
            {
                Id = 6,
                Stamp = "Stamp3",
                Model = "Model3",
                RegistrationDate = DateTime.UtcNow,
                Supplier = Suppliers[3],
                SupplierId = 4
            },
            new Offer()
            {
                Id = 7,
                Stamp = "Stamp2",
                Model = "Model1",
                RegistrationDate = DateTime.UtcNow,
                Supplier = Suppliers[3],
                SupplierId = 4
            },
            new Offer()
            {
                Id = 8,
                Stamp = "Stamp1",
                Model = "Model2",
                RegistrationDate = DateTime.UtcNow,
                Supplier = Suppliers[3],
                SupplierId = 4
            },
            new Offer()
            {
                Id = 9,
                Stamp = "Stamp2",
                Model = "Model3",
                RegistrationDate = DateTime.UtcNow,
                Supplier = Suppliers[3],
                SupplierId = 4
            },
            new Offer()
            {
                Id = 10,
                Stamp = "Stamp3",
                Model = "Model2",
                RegistrationDate = DateTime.UtcNow,
                Supplier = Suppliers[4],
                SupplierId = 5
            },
            new Offer()
            {
                Id = 11,
                Stamp = "Stamp3",
                Model = "Model2",
                RegistrationDate = DateTime.UtcNow,
                Supplier = Suppliers[0],
                SupplierId = 1
            },
            new Offer()
            {
                Id = 12,
                Stamp = "Stamp1",
                Model = "Model1",
                RegistrationDate = DateTime.UtcNow,
                Supplier = Suppliers[2],
                SupplierId = 3
            },
            new Offer()
            {
                Id = 13,
                Stamp = "Stamp1",
                Model = "Model3",
                RegistrationDate = DateTime.UtcNow,
                Supplier = Suppliers[1],
                SupplierId = 2
            },new Offer()
            {
                Id = 14,
                Stamp = "Stamp3",
                Model = "Model1",
                RegistrationDate = DateTime.UtcNow,
                Supplier = Suppliers[1],
                SupplierId = 2
            },
            new Offer()
            {
                Id = 15,
                Stamp = "Stamp1",
                Model = "Model1",
                RegistrationDate = DateTime.UtcNow,
                Supplier = Suppliers[0],
                SupplierId = 1
            }
        };

        _lengthOffers = Offers.Count + 1;
        _lengthSuppliers = Suppliers.Count + 1;
    }

    public List<Offer> Offers { get; }
    public List<Supplier> Suppliers { get;  }

    public int Save(Offer entity)
    {
        entity.Id = _lengthOffers++;
        Offers.Add(entity);
        
        return entity.Id;
    }

    public int Save(Supplier entity)
    {
        entity.Id = _lengthSuppliers++;
        Suppliers.Add(entity);
        
        return entity.Id;
    }
}
