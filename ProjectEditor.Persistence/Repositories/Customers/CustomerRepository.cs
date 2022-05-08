using ProjectEditor.Common.Attributes;
using ProjectEditor.Core.Repositories.Customers;
using ProjectEditor.Persistence.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEditor.Persistence.Repositories.Customers
{
    [MapServiceDependency(nameof(CustomerRepository))]
    public class CustomerRepository :BaseRepository, ICustomerRepository

    {
    }
}
