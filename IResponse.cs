namespace FacePlusPlusLib
{
    public interface IResponse
    {
        string RequestId { get; set; }
        string ErrorMessage { get; set; }
        int TimeUsed { get; set; }
    }
}