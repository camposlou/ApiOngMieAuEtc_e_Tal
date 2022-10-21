namespace ApiOngMieAuEtc_e_Tal.Utils
{
    public interface IDataBaseSettings
    {
        string AdoptingCollectionName { get; set; }
        string AnimalCollectionName { get; set; }
        string AdoptionCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DataBaseName { get; set; }
    }
}
