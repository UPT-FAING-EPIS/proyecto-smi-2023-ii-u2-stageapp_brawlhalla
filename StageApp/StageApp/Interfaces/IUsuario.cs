namespace StageApp.Interfaces;

public interface IUsuario
{
    public Task<List<UsuariosModels>> GetAll();
    public Task<UsuariosModels> GetById(int id);
    public Task<int> InsertEquipo(UsuariosModels A);
    public Task<int> DeleteEquipo(UsuariosModels A);
    public Task<int> UpdateEquipo(UsuariosModels A);

}

