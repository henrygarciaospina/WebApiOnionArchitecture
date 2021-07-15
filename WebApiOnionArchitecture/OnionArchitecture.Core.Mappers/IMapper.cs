namespace OnionArchitecture.Core.Mappers
{
    public interface IMapper<Target, Source> where Target : class, new() where Source : class, new()
    {
        Target Map(Source source);
    }
}
