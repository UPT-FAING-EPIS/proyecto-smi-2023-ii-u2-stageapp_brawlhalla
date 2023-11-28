namespace StageApp.Interfaces;

public interface ITorneo
{
    public Task<List<TorneoModels>> GetAll();
    public Task<TorneoModels> GetById(int id);
    public Task<int> InsertTorneo(TorneoModels A);
    public Task<int> DeleteTorneo(TorneoModels A);
    public Task<int> UpdateTorneo(TorneoModels A);

}

