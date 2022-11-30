namespace BlazorControlWork.IService
{
    public interface IUserService
    {
        List<User> GetUsers();
        User Save(User user);
        User UploadPdf(string _id,byte[] pdf);
        void DeletePdf(string _id);
    }
}
