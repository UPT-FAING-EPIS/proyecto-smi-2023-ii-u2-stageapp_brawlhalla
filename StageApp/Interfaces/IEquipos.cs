namespace StageApp.Interfaces;

public interface IEquipos
{
    public Task<List<EquiposModels>> GetAll();
    public Task<EquiposModels> GetById(int id);
    public Task<int> InsertEquipo(EquiposModels A);
    public Task<int> DeleteEquipo(EquiposModels A);
    public Task<int> UpdateEquipo(EquiposModels A);

}

