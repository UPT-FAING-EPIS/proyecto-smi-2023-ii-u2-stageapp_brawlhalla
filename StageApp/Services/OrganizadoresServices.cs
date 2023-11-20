using Stage_App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_App.Services;

public class OrganizadoresServices : IOrganizadores
{
    private readonly SQLLiteHelper<OrganizadoresModels> db;
    public OrganizadoresServices()
    => db = new();

    public Task<int> DeleteOrganizador(OrganizadoresModels A)
     => Task.FromResult(db.Delete(A));

    public Task<List<OrganizadoresModels>> GetAll()
     => Task.FromResult(db.GetAllData());

    public Task<OrganizadoresModels> GetById(int id)
    => Task.FromResult(db.Get(id));

    public Task<int> InsertOrganizador(OrganizadoresModels A)
   => Task.FromResult(db.Add(A));
    

    public Task<int> UpdateOrganizador(OrganizadoresModels A)
    => Task.FromResult(db.Update(A));

}
