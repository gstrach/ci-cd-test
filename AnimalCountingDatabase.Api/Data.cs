
using Microsoft.EntityFrameworkCore;

namespace AnimalCountingDatabase.Api
{
    public class Customer
    {
        public int Id{ get; set; }
        public string CustomerName { get; set; }
    }

    public class CustomerContext: DbContext
    {

    }


}

