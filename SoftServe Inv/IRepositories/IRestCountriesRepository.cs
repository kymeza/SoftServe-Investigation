namespace SoftServe_Inv.IRepositories
{
    public interface IRestCountriesRepository
    {
        Task<IEnumerable<dynamic>> GetAllCountriesAsync();

    }
}
