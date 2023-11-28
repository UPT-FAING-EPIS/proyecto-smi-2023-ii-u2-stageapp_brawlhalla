namespace StageApp.Interfaces;

public interface IEmparejamiento
{
    public Task<List<EmparejamientoModels>> GetAll();
    public Task<EmparejamientoModels> GetById(int id);
    public Task<int> InsertEquipo(EmparejamientoModels A);
    public Task<int> DeleteEquipo(EmparejamientoModels A);
    public Task<int> UpdateEquipo(EmparejamientoModels A);

}

