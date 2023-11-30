namespace StageApp.Interfaces;

public interface IResultados
{
    public Task<List<ResultadosModels>> GetAll();
    public Task<ResultadosModels> GetById(int id);
    public Task<int> InsertResultados(ResultadosModels A);
    public Task<int> DeleteEResultados(ResultadosModels A);
    public Task<int> UpdateResultados(ResultadosModels A);

}

