using DapperTest.Repository.Models;
using System.Collections.Generic;

namespace DapperTest.Repository
{
    public interface IDapperTestRepository
    {
        List<Test> getRecords();
    }
}
