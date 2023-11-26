namespace SberCase.Models
{
    public interface IBaseModel<T>
    {
        T Id { get; set; }
    }
}
