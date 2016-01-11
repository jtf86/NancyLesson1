namespace FriendLetter
{
  using Nancy;

  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["hello.html"];
      Get["/favorite_photos"] = _ => View["favorite_photos.html"];
    }
  }
}
